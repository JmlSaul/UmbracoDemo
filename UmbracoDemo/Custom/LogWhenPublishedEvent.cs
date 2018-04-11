using Umbraco.Core;
using Umbraco.Core.Logging;

namespace UmbracoDemo.Custom
{
    //这个类这样写好就行了，不需要在哪里使用。估计程序启动时候Umbraco会自动扫描继承自ApplicationEventHandler的类，并执行ApplicationStarted方法
    public class LogWhenPublishedEvent : ApplicationEventHandler
    {
        protected override void ApplicationStarted(UmbracoApplicationBase umbracoApplication, ApplicationContext applicationContext)
        {
            base.ApplicationStarted(umbracoApplication, applicationContext);
            Umbraco.Core.Services.ContentService.Published += ContentService_Published;
        }

        private void ContentService_Published(Umbraco.Core.Publishing.IPublishingStrategy sender, Umbraco.Core.Events.PublishEventArgs<Umbraco.Core.Models.IContent> e)
        {
            // LogHelper will write to tracelog.txt
            LogHelper.Info(typeof(LogWhenPublishedEvent), "Something has been published");
        }
    }
}