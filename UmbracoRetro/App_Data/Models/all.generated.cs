using  System;
using  System.Collections.Generic;
using  System.Linq.Expressions;
using  System.Web;
using  Umbraco.Core.Models;
using  Umbraco.Core.Models.PublishedContent;
using  Umbraco.Web;
using  Umbraco.ModelsBuilder;
using  Umbraco.ModelsBuilder.Umbraco;
[assembly: PureLiveAssembly]
[assembly:ModelsBuilderAssembly(PureLive = true, SourceHash = "5adda96e48b0070c")]
[assembly:System.Reflection.AssemblyVersion("0.0.0.1")]


// FILE: models.generated.cs

//------------------------------------------------------------------------------
// <auto-generated>
//   This code was generated by a tool.
//
//    Umbraco.ModelsBuilder v3.0.4.0
//
//   Changes to this file will be lost if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------















namespace Umbraco.Web.PublishedContentModels
{
	/// <summary>Home</summary>
	[PublishedContentModel("home")]
	public partial class Home : PublishedContentModel, IFeaturedItemsControl, IIntroControls, ILastBlogPostsControls, ITestimonialsControls, ITitleControls
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "home";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public Home(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Home, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Featured Items: Enter the featured items to display
		///</summary>
		[ImplementPropertyType("featuredItems")]
		public Archetype.Models.ArchetypeModel FeaturedItems
		{
			get { return FeaturedItemsControl.GetFeaturedItems(this); }
		}

		///<summary>
		/// Intro: Enter intro for the home page
		///</summary>
		[ImplementPropertyType("intro")]
		public string Intro
		{
			get { return IntroControls.GetIntro(this); }
		}

		///<summary>
		/// Last Blog Posts Introduction: Enter the introduction to the latest blog posts section
		///</summary>
		[ImplementPropertyType("lastBlogPostsIntroduction")]
		public IHtmlString LastBlogPostsIntroduction
		{
			get { return LastBlogPostsControls.GetLastBlogPostsIntroduction(this); }
		}

		///<summary>
		/// Last Blog Posts Title: Enter the title of the latest blog posts section
		///</summary>
		[ImplementPropertyType("lastBlogPostsTitle")]
		public string LastBlogPostsTitle
		{
			get { return LastBlogPostsControls.GetLastBlogPostsTitle(this); }
		}

		///<summary>
		/// Testimonial List: Enter the testimonials to display
		///</summary>
		[ImplementPropertyType("testimonialList")]
		public Archetype.Models.ArchetypeModel TestimonialList
		{
			get { return TestimonialsControls.GetTestimonialList(this); }
		}

		///<summary>
		/// Testimonials Introduction: Enter the introduction for testimonials section
		///</summary>
		[ImplementPropertyType("testimonialsIntroduction")]
		public IHtmlString TestimonialsIntroduction
		{
			get { return TestimonialsControls.GetTestimonialsIntroduction(this); }
		}

		///<summary>
		/// Testimonials Title: Enter the title for testimonials section
		///</summary>
		[ImplementPropertyType("testimonialsTitle")]
		public string TestimonialsTitle
		{
			get { return TestimonialsControls.GetTestimonialsTitle(this); }
		}

		///<summary>
		/// Sub Title: Enter sub title
		///</summary>
		[ImplementPropertyType("subTitle")]
		public IHtmlString SubTitle
		{
			get { return TitleControls.GetSubTitle(this); }
		}

		///<summary>
		/// Title: Enter the title, if blank the name of the page will be used
		///</summary>
		[ImplementPropertyType("title")]
		public string Title
		{
			get { return TitleControls.GetTitle(this); }
		}
	}

	/// <summary>Blog</summary>
	[PublishedContentModel("blog")]
	public partial class Blog : PublishedContentModel, ITitleControls
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "blog";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public Blog(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Blog, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Sub Title: Enter sub title
		///</summary>
		[ImplementPropertyType("subTitle")]
		public IHtmlString SubTitle
		{
			get { return TitleControls.GetSubTitle(this); }
		}

		///<summary>
		/// Title: Enter the title, if blank the name of the page will be used
		///</summary>
		[ImplementPropertyType("title")]
		public string Title
		{
			get { return TitleControls.GetTitle(this); }
		}
	}

	/// <summary>Portfolio</summary>
	[PublishedContentModel("portfolio")]
	public partial class Portfolio : PublishedContentModel, ITitleControls, ITopNavigationControls
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "portfolio";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public Portfolio(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Portfolio, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Sub Title: Enter sub title
		///</summary>
		[ImplementPropertyType("subTitle")]
		public IHtmlString SubTitle
		{
			get { return TitleControls.GetSubTitle(this); }
		}

		///<summary>
		/// Title: Enter the title, if blank the name of the page will be used
		///</summary>
		[ImplementPropertyType("title")]
		public string Title
		{
			get { return TitleControls.GetTitle(this); }
		}

		///<summary>
		/// umbraco Navi Hide: Tick to exclude form navigation
		///</summary>
		[ImplementPropertyType("umbracoNaviHide")]
		public bool UmbracoNaviHide
		{
			get { return TopNavigationControls.GetUmbracoNaviHide(this); }
		}
	}

	/// <summary>Services</summary>
	[PublishedContentModel("services")]
	public partial class Services : PublishedContentModel, ITitleControls
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "services";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public Services(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Services, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Sub Title: Enter sub title
		///</summary>
		[ImplementPropertyType("subTitle")]
		public IHtmlString SubTitle
		{
			get { return TitleControls.GetSubTitle(this); }
		}

		///<summary>
		/// Title: Enter the title, if blank the name of the page will be used
		///</summary>
		[ImplementPropertyType("title")]
		public string Title
		{
			get { return TitleControls.GetTitle(this); }
		}
	}

	/// <summary>About</summary>
	[PublishedContentModel("about")]
	public partial class About : PublishedContentModel, IBasicContentControls, ITitleControls, ITopNavigationControls
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "about";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public About(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<About, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Content Grid: Enter content
		///</summary>
		[ImplementPropertyType("contentGrid")]
		public Newtonsoft.Json.Linq.JToken ContentGrid
		{
			get { return BasicContentControls.GetContentGrid(this); }
		}

		///<summary>
		/// Sub Title: Enter sub title
		///</summary>
		[ImplementPropertyType("subTitle")]
		public IHtmlString SubTitle
		{
			get { return TitleControls.GetSubTitle(this); }
		}

		///<summary>
		/// Title: Enter the title, if blank the name of the page will be used
		///</summary>
		[ImplementPropertyType("title")]
		public string Title
		{
			get { return TitleControls.GetTitle(this); }
		}

		///<summary>
		/// umbraco Navi Hide: Tick to exclude form navigation
		///</summary>
		[ImplementPropertyType("umbracoNaviHide")]
		public bool UmbracoNaviHide
		{
			get { return TopNavigationControls.GetUmbracoNaviHide(this); }
		}
	}

	/// <summary>Contact</summary>
	[PublishedContentModel("contact")]
	public partial class Contact : PublishedContentModel, ITitleControls
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "contact";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public Contact(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Contact, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Sub Title: Enter sub title
		///</summary>
		[ImplementPropertyType("subTitle")]
		public IHtmlString SubTitle
		{
			get { return TitleControls.GetSubTitle(this); }
		}

		///<summary>
		/// Title: Enter the title, if blank the name of the page will be used
		///</summary>
		[ImplementPropertyType("title")]
		public string Title
		{
			get { return TitleControls.GetTitle(this); }
		}
	}

	// Mixin content Type 1068 with alias "introControls"
	/// <summary>Intro Controls</summary>
	public partial interface IIntroControls : IPublishedContent
	{
		/// <summary>Intro</summary>
		string Intro { get; }
	}

	/// <summary>Intro Controls</summary>
	[PublishedContentModel("introControls")]
	public partial class IntroControls : PublishedContentModel, IIntroControls
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "introControls";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public IntroControls(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<IntroControls, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Intro: Enter intro for the home page
		///</summary>
		[ImplementPropertyType("intro")]
		public string Intro
		{
			get { return GetIntro(this); }
		}

		/// <summary>Static getter for Intro</summary>
		public static string GetIntro(IIntroControls that) { return that.GetPropertyValue<string>("intro"); }
	}

	// Mixin content Type 1069 with alias "titleControls"
	/// <summary>Title Controls</summary>
	public partial interface ITitleControls : IPublishedContent
	{
		/// <summary>Sub Title</summary>
		IHtmlString SubTitle { get; }

		/// <summary>Title</summary>
		string Title { get; }
	}

	/// <summary>Title Controls</summary>
	[PublishedContentModel("titleControls")]
	public partial class TitleControls : PublishedContentModel, ITitleControls
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "titleControls";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public TitleControls(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<TitleControls, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Sub Title: Enter sub title
		///</summary>
		[ImplementPropertyType("subTitle")]
		public IHtmlString SubTitle
		{
			get { return GetSubTitle(this); }
		}

		/// <summary>Static getter for Sub Title</summary>
		public static IHtmlString GetSubTitle(ITitleControls that) { return that.GetPropertyValue<IHtmlString>("subTitle"); }

		///<summary>
		/// Title: Enter the title, if blank the name of the page will be used
		///</summary>
		[ImplementPropertyType("title")]
		public string Title
		{
			get { return GetTitle(this); }
		}

		/// <summary>Static getter for Title</summary>
		public static string GetTitle(ITitleControls that) { return that.GetPropertyValue<string>("title"); }
	}

	// Mixin content Type 1073 with alias "basicContentControls"
	/// <summary>Basic Content Controls</summary>
	public partial interface IBasicContentControls : IPublishedContent
	{
		/// <summary>Content Grid</summary>
		Newtonsoft.Json.Linq.JToken ContentGrid { get; }
	}

	/// <summary>Basic Content Controls</summary>
	[PublishedContentModel("basicContentControls")]
	public partial class BasicContentControls : PublishedContentModel, IBasicContentControls
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "basicContentControls";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public BasicContentControls(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<BasicContentControls, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Content Grid: Enter content
		///</summary>
		[ImplementPropertyType("contentGrid")]
		public Newtonsoft.Json.Linq.JToken ContentGrid
		{
			get { return GetContentGrid(this); }
		}

		/// <summary>Static getter for Content Grid</summary>
		public static Newtonsoft.Json.Linq.JToken GetContentGrid(IBasicContentControls that) { return that.GetPropertyValue<Newtonsoft.Json.Linq.JToken>("contentGrid"); }
	}

	// Mixin content Type 1075 with alias "topNavigationControls"
	/// <summary>Top Navigation Controls</summary>
	public partial interface ITopNavigationControls : IPublishedContent
	{
		/// <summary>umbraco Navi Hide</summary>
		bool UmbracoNaviHide { get; }
	}

	/// <summary>Top Navigation Controls</summary>
	[PublishedContentModel("topNavigationControls")]
	public partial class TopNavigationControls : PublishedContentModel, ITopNavigationControls
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "topNavigationControls";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public TopNavigationControls(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<TopNavigationControls, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// umbraco Navi Hide: Tick to exclude form navigation
		///</summary>
		[ImplementPropertyType("umbracoNaviHide")]
		public bool UmbracoNaviHide
		{
			get { return GetUmbracoNaviHide(this); }
		}

		/// <summary>Static getter for umbraco Navi Hide</summary>
		public static bool GetUmbracoNaviHide(ITopNavigationControls that) { return that.GetPropertyValue<bool>("umbracoNaviHide"); }
	}

	// Mixin content Type 1079 with alias "featuredItemsControl"
	/// <summary>Featured Items Controls</summary>
	public partial interface IFeaturedItemsControl : IPublishedContent
	{
		/// <summary>Featured Items</summary>
		Archetype.Models.ArchetypeModel FeaturedItems { get; }
	}

	/// <summary>Featured Items Controls</summary>
	[PublishedContentModel("featuredItemsControl")]
	public partial class FeaturedItemsControl : PublishedContentModel, IFeaturedItemsControl
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "featuredItemsControl";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public FeaturedItemsControl(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<FeaturedItemsControl, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Featured Items: Enter the featured items to display
		///</summary>
		[ImplementPropertyType("featuredItems")]
		public Archetype.Models.ArchetypeModel FeaturedItems
		{
			get { return GetFeaturedItems(this); }
		}

		/// <summary>Static getter for Featured Items</summary>
		public static Archetype.Models.ArchetypeModel GetFeaturedItems(IFeaturedItemsControl that) { return that.GetPropertyValue<Archetype.Models.ArchetypeModel>("featuredItems"); }
	}

	// Mixin content Type 1087 with alias "articleControls"
	/// <summary>Article Controls</summary>
	public partial interface IArticleControls : IPublishedContent
	{
		/// <summary>Article Image</summary>
		string ArticleImage { get; }

		/// <summary>Article Intro</summary>
		string ArticleIntro { get; }
	}

	/// <summary>Article Controls</summary>
	[PublishedContentModel("articleControls")]
	public partial class ArticleControls : PublishedContentModel, IArticleControls
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "articleControls";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public ArticleControls(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<ArticleControls, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Article Image: Choose the image for the article
		///</summary>
		[ImplementPropertyType("articleImage")]
		public string ArticleImage
		{
			get { return GetArticleImage(this); }
		}

		/// <summary>Static getter for Article Image</summary>
		public static string GetArticleImage(IArticleControls that) { return that.GetPropertyValue<string>("articleImage"); }

		///<summary>
		/// Article Intro: Enter article intro
		///</summary>
		[ImplementPropertyType("articleIntro")]
		public string ArticleIntro
		{
			get { return GetArticleIntro(this); }
		}

		/// <summary>Static getter for Article Intro</summary>
		public static string GetArticleIntro(IArticleControls that) { return that.GetPropertyValue<string>("articleIntro"); }
	}

	/// <summary>Blog Post</summary>
	[PublishedContentModel("blogPost")]
	public partial class BlogPost : PublishedContentModel, IArticleControls, IBasicContentControls, ITitleControls
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "blogPost";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public BlogPost(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<BlogPost, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Article Image: Choose the image for the article
		///</summary>
		[ImplementPropertyType("articleImage")]
		public string ArticleImage
		{
			get { return ArticleControls.GetArticleImage(this); }
		}

		///<summary>
		/// Article Intro: Enter article intro
		///</summary>
		[ImplementPropertyType("articleIntro")]
		public string ArticleIntro
		{
			get { return ArticleControls.GetArticleIntro(this); }
		}

		///<summary>
		/// Content Grid: Enter content
		///</summary>
		[ImplementPropertyType("contentGrid")]
		public Newtonsoft.Json.Linq.JToken ContentGrid
		{
			get { return BasicContentControls.GetContentGrid(this); }
		}

		///<summary>
		/// Sub Title: Enter sub title
		///</summary>
		[ImplementPropertyType("subTitle")]
		public IHtmlString SubTitle
		{
			get { return TitleControls.GetSubTitle(this); }
		}

		///<summary>
		/// Title: Enter the title, if blank the name of the page will be used
		///</summary>
		[ImplementPropertyType("title")]
		public string Title
		{
			get { return TitleControls.GetTitle(this); }
		}
	}

	// Mixin content Type 1108 with alias "lastBlogPostsControls"
	/// <summary>Last Blog Posts Controls</summary>
	public partial interface ILastBlogPostsControls : IPublishedContent
	{
		/// <summary>Last Blog Posts Introduction</summary>
		IHtmlString LastBlogPostsIntroduction { get; }

		/// <summary>Last Blog Posts Title</summary>
		string LastBlogPostsTitle { get; }
	}

	/// <summary>Last Blog Posts Controls</summary>
	[PublishedContentModel("lastBlogPostsControls")]
	public partial class LastBlogPostsControls : PublishedContentModel, ILastBlogPostsControls
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "lastBlogPostsControls";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public LastBlogPostsControls(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<LastBlogPostsControls, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Last Blog Posts Introduction: Enter the introduction to the latest blog posts section
		///</summary>
		[ImplementPropertyType("lastBlogPostsIntroduction")]
		public IHtmlString LastBlogPostsIntroduction
		{
			get { return GetLastBlogPostsIntroduction(this); }
		}

		/// <summary>Static getter for Last Blog Posts Introduction</summary>
		public static IHtmlString GetLastBlogPostsIntroduction(ILastBlogPostsControls that) { return that.GetPropertyValue<IHtmlString>("lastBlogPostsIntroduction"); }

		///<summary>
		/// Last Blog Posts Title: Enter the title of the latest blog posts section
		///</summary>
		[ImplementPropertyType("lastBlogPostsTitle")]
		public string LastBlogPostsTitle
		{
			get { return GetLastBlogPostsTitle(this); }
		}

		/// <summary>Static getter for Last Blog Posts Title</summary>
		public static string GetLastBlogPostsTitle(ILastBlogPostsControls that) { return that.GetPropertyValue<string>("lastBlogPostsTitle"); }
	}

	// Mixin content Type 1109 with alias "testimonialsControls"
	/// <summary>Testimonials Controls</summary>
	public partial interface ITestimonialsControls : IPublishedContent
	{
		/// <summary>Testimonial List</summary>
		Archetype.Models.ArchetypeModel TestimonialList { get; }

		/// <summary>Testimonials Introduction</summary>
		IHtmlString TestimonialsIntroduction { get; }

		/// <summary>Testimonials Title</summary>
		string TestimonialsTitle { get; }
	}

	/// <summary>Testimonials Controls</summary>
	[PublishedContentModel("testimonialsControls")]
	public partial class TestimonialsControls : PublishedContentModel, ITestimonialsControls
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "testimonialsControls";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public TestimonialsControls(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<TestimonialsControls, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Testimonial List: Enter the testimonials to display
		///</summary>
		[ImplementPropertyType("testimonialList")]
		public Archetype.Models.ArchetypeModel TestimonialList
		{
			get { return GetTestimonialList(this); }
		}

		/// <summary>Static getter for Testimonial List</summary>
		public static Archetype.Models.ArchetypeModel GetTestimonialList(ITestimonialsControls that) { return that.GetPropertyValue<Archetype.Models.ArchetypeModel>("testimonialList"); }

		///<summary>
		/// Testimonials Introduction: Enter the introduction for testimonials section
		///</summary>
		[ImplementPropertyType("testimonialsIntroduction")]
		public IHtmlString TestimonialsIntroduction
		{
			get { return GetTestimonialsIntroduction(this); }
		}

		/// <summary>Static getter for Testimonials Introduction</summary>
		public static IHtmlString GetTestimonialsIntroduction(ITestimonialsControls that) { return that.GetPropertyValue<IHtmlString>("testimonialsIntroduction"); }

		///<summary>
		/// Testimonials Title: Enter the title for testimonials section
		///</summary>
		[ImplementPropertyType("testimonialsTitle")]
		public string TestimonialsTitle
		{
			get { return GetTestimonialsTitle(this); }
		}

		/// <summary>Static getter for Testimonials Title</summary>
		public static string GetTestimonialsTitle(ITestimonialsControls that) { return that.GetPropertyValue<string>("testimonialsTitle"); }
	}

	/// <summary>Folder</summary>
	[PublishedContentModel("Folder")]
	public partial class Folder : PublishedContentModel
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "Folder";
		public new const PublishedItemType ModelItemType = PublishedItemType.Media;
#pragma warning restore 0109

		public Folder(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Folder, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Contents:
		///</summary>
		[ImplementPropertyType("contents")]
		public object Contents
		{
			get { return this.GetPropertyValue("contents"); }
		}
	}

	/// <summary>Image</summary>
	[PublishedContentModel("Image")]
	public partial class Image : PublishedContentModel
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "Image";
		public new const PublishedItemType ModelItemType = PublishedItemType.Media;
#pragma warning restore 0109

		public Image(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Image, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Size
		///</summary>
		[ImplementPropertyType("umbracoBytes")]
		public string UmbracoBytes
		{
			get { return this.GetPropertyValue<string>("umbracoBytes"); }
		}

		///<summary>
		/// Type
		///</summary>
		[ImplementPropertyType("umbracoExtension")]
		public string UmbracoExtension
		{
			get { return this.GetPropertyValue<string>("umbracoExtension"); }
		}

		///<summary>
		/// Upload image
		///</summary>
		[ImplementPropertyType("umbracoFile")]
		public Umbraco.Web.Models.ImageCropDataSet UmbracoFile
		{
			get { return this.GetPropertyValue<Umbraco.Web.Models.ImageCropDataSet>("umbracoFile"); }
		}

		///<summary>
		/// Height
		///</summary>
		[ImplementPropertyType("umbracoHeight")]
		public string UmbracoHeight
		{
			get { return this.GetPropertyValue<string>("umbracoHeight"); }
		}

		///<summary>
		/// Width
		///</summary>
		[ImplementPropertyType("umbracoWidth")]
		public string UmbracoWidth
		{
			get { return this.GetPropertyValue<string>("umbracoWidth"); }
		}
	}

	/// <summary>File</summary>
	[PublishedContentModel("File")]
	public partial class File : PublishedContentModel
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "File";
		public new const PublishedItemType ModelItemType = PublishedItemType.Media;
#pragma warning restore 0109

		public File(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<File, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Size
		///</summary>
		[ImplementPropertyType("umbracoBytes")]
		public string UmbracoBytes
		{
			get { return this.GetPropertyValue<string>("umbracoBytes"); }
		}

		///<summary>
		/// Type
		///</summary>
		[ImplementPropertyType("umbracoExtension")]
		public string UmbracoExtension
		{
			get { return this.GetPropertyValue<string>("umbracoExtension"); }
		}

		///<summary>
		/// Upload file
		///</summary>
		[ImplementPropertyType("umbracoFile")]
		public object UmbracoFile
		{
			get { return this.GetPropertyValue("umbracoFile"); }
		}
	}

	/// <summary>Member</summary>
	[PublishedContentModel("Member")]
	public partial class Member : PublishedContentModel
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "Member";
		public new const PublishedItemType ModelItemType = PublishedItemType.Member;
#pragma warning restore 0109

		public Member(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Member, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Is Approved
		///</summary>
		[ImplementPropertyType("umbracoMemberApproved")]
		public bool UmbracoMemberApproved
		{
			get { return this.GetPropertyValue<bool>("umbracoMemberApproved"); }
		}

		///<summary>
		/// Comments
		///</summary>
		[ImplementPropertyType("umbracoMemberComments")]
		public string UmbracoMemberComments
		{
			get { return this.GetPropertyValue<string>("umbracoMemberComments"); }
		}

		///<summary>
		/// Failed Password Attempts
		///</summary>
		[ImplementPropertyType("umbracoMemberFailedPasswordAttempts")]
		public string UmbracoMemberFailedPasswordAttempts
		{
			get { return this.GetPropertyValue<string>("umbracoMemberFailedPasswordAttempts"); }
		}

		///<summary>
		/// Last Lockout Date
		///</summary>
		[ImplementPropertyType("umbracoMemberLastLockoutDate")]
		public string UmbracoMemberLastLockoutDate
		{
			get { return this.GetPropertyValue<string>("umbracoMemberLastLockoutDate"); }
		}

		///<summary>
		/// Last Login Date
		///</summary>
		[ImplementPropertyType("umbracoMemberLastLogin")]
		public string UmbracoMemberLastLogin
		{
			get { return this.GetPropertyValue<string>("umbracoMemberLastLogin"); }
		}

		///<summary>
		/// Last Password Change Date
		///</summary>
		[ImplementPropertyType("umbracoMemberLastPasswordChangeDate")]
		public string UmbracoMemberLastPasswordChangeDate
		{
			get { return this.GetPropertyValue<string>("umbracoMemberLastPasswordChangeDate"); }
		}

		///<summary>
		/// Is Locked Out
		///</summary>
		[ImplementPropertyType("umbracoMemberLockedOut")]
		public bool UmbracoMemberLockedOut
		{
			get { return this.GetPropertyValue<bool>("umbracoMemberLockedOut"); }
		}

		///<summary>
		/// Password Answer
		///</summary>
		[ImplementPropertyType("umbracoMemberPasswordRetrievalAnswer")]
		public string UmbracoMemberPasswordRetrievalAnswer
		{
			get { return this.GetPropertyValue<string>("umbracoMemberPasswordRetrievalAnswer"); }
		}

		///<summary>
		/// Password Question
		///</summary>
		[ImplementPropertyType("umbracoMemberPasswordRetrievalQuestion")]
		public string UmbracoMemberPasswordRetrievalQuestion
		{
			get { return this.GetPropertyValue<string>("umbracoMemberPasswordRetrievalQuestion"); }
		}
	}

}



// EOF
