<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vminutes_1_0\Models\QueryOrgDiyTemplatesResponseBody;

use AlibabaCloud\Tea\Model;

class diyTemplates extends Model
{
    /**
     * @var int
     */
    public $acceptTimes;

    /**
     * @var int
     */
    public $createTime;

    /**
     * @var string
     */
    public $creatorNick;

    /**
     * @var string
     */
    public $creatorUnionId;

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
     * @var string
     */
    public $status;
    protected $_name = [
        'acceptTimes' => 'acceptTimes',
        'createTime' => 'createTime',
        'creatorNick' => 'creatorNick',
        'creatorUnionId' => 'creatorUnionId',
        'diyTemplateBriefIntro' => 'diyTemplateBriefIntro',
        'diyTemplateIconUrl' => 'diyTemplateIconUrl',
        'diyTemplateKey' => 'diyTemplateKey',
        'diyTemplateLatestVersion' => 'diyTemplateLatestVersion',
        'diyTemplateSource' => 'diyTemplateSource',
        'diyTemplateTitle' => 'diyTemplateTitle',
        'status' => 'status',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->acceptTimes) {
            $res['acceptTimes'] = $this->acceptTimes;
        }
        if (null !== $this->createTime) {
            $res['createTime'] = $this->createTime;
        }
        if (null !== $this->creatorNick) {
            $res['creatorNick'] = $this->creatorNick;
        }
        if (null !== $this->creatorUnionId) {
            $res['creatorUnionId'] = $this->creatorUnionId;
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
        if (null !== $this->status) {
            $res['status'] = $this->status;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return diyTemplates
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['acceptTimes'])) {
            $model->acceptTimes = $map['acceptTimes'];
        }
        if (isset($map['createTime'])) {
            $model->createTime = $map['createTime'];
        }
        if (isset($map['creatorNick'])) {
            $model->creatorNick = $map['creatorNick'];
        }
        if (isset($map['creatorUnionId'])) {
            $model->creatorUnionId = $map['creatorUnionId'];
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
        if (isset($map['status'])) {
            $model->status = $map['status'];
        }

        return $model;
    }
}
