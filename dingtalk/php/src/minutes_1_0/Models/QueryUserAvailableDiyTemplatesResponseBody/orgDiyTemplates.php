<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vminutes_1_0\Models\QueryUserAvailableDiyTemplatesResponseBody;

use AlibabaCloud\Tea\Model;

class orgDiyTemplates extends Model
{
    /**
     * @var int
     */
    public $createTime;

    /**
     * @var string
     */
    public $diyTemplateBriefIntro;

    /**
     * @var string
     */
    public $diyTemplateIconUrl;

    /**
     * @var string
     */
    public $diyTemplateKey;

    /**
     * @var int
     */
    public $diyTemplateLatestVersion;

    /**
     * @var string
     */
    public $diyTemplateSource;

    /**
     * @var string
     */
    public $diyTemplateTitle;

    /**
     * @var int
     */
    public $modifiedTime;
    protected $_name = [
        'createTime' => 'createTime',
        'diyTemplateBriefIntro' => 'diyTemplateBriefIntro',
        'diyTemplateIconUrl' => 'diyTemplateIconUrl',
        'diyTemplateKey' => 'diyTemplateKey',
        'diyTemplateLatestVersion' => 'diyTemplateLatestVersion',
        'diyTemplateSource' => 'diyTemplateSource',
        'diyTemplateTitle' => 'diyTemplateTitle',
        'modifiedTime' => 'modifiedTime',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->createTime) {
            $res['createTime'] = $this->createTime;
        }
        if (null !== $this->diyTemplateBriefIntro) {
            $res['diyTemplateBriefIntro'] = $this->diyTemplateBriefIntro;
        }
        if (null !== $this->diyTemplateIconUrl) {
            $res['diyTemplateIconUrl'] = $this->diyTemplateIconUrl;
        }
        if (null !== $this->diyTemplateKey) {
            $res['diyTemplateKey'] = $this->diyTemplateKey;
        }
        if (null !== $this->diyTemplateLatestVersion) {
            $res['diyTemplateLatestVersion'] = $this->diyTemplateLatestVersion;
        }
        if (null !== $this->diyTemplateSource) {
            $res['diyTemplateSource'] = $this->diyTemplateSource;
        }
        if (null !== $this->diyTemplateTitle) {
            $res['diyTemplateTitle'] = $this->diyTemplateTitle;
        }
        if (null !== $this->modifiedTime) {
            $res['modifiedTime'] = $this->modifiedTime;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return orgDiyTemplates
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['createTime'])) {
            $model->createTime = $map['createTime'];
        }
        if (isset($map['diyTemplateBriefIntro'])) {
            $model->diyTemplateBriefIntro = $map['diyTemplateBriefIntro'];
        }
        if (isset($map['diyTemplateIconUrl'])) {
            $model->diyTemplateIconUrl = $map['diyTemplateIconUrl'];
        }
        if (isset($map['diyTemplateKey'])) {
            $model->diyTemplateKey = $map['diyTemplateKey'];
        }
        if (isset($map['diyTemplateLatestVersion'])) {
            $model->diyTemplateLatestVersion = $map['diyTemplateLatestVersion'];
        }
        if (isset($map['diyTemplateSource'])) {
            $model->diyTemplateSource = $map['diyTemplateSource'];
        }
        if (isset($map['diyTemplateTitle'])) {
            $model->diyTemplateTitle = $map['diyTemplateTitle'];
        }
        if (isset($map['modifiedTime'])) {
            $model->modifiedTime = $map['modifiedTime'];
        }

        return $model;
    }
}
