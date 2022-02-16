<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vapaas_1_0\Models\BatchQueryByTemplateKeyResponseBody;

use AlibabaCloud\Tea\Model;

class templateList extends Model
{
    /**
     * @var string
     */
    public $templateKey;

    /**
     * @var string
     */
    public $name;

    /**
     * @var string
     */
    public $simpleDesc;

    /**
     * @var string
     */
    public $appDesc;

    /**
     * @var string
     */
    public $appIcon;

    /**
     * @var string
     */
    public $category;

    /**
     * @var string
     */
    public $providerName;

    /**
     * @var float
     */
    public $installTimes;

    /**
     * @var string[]
     */
    public $industryLabelList;

    /**
     * @var string[]
     */
    public $roleLabelList;

    /**
     * @var string[]
     */
    public $adaptEnv;

    /**
     * @var string
     */
    public $expUrl;

    /**
     * @var string[]
     */
    public $previewMediaList;

    /**
     * @var string[]
     */
    public $mobilePreviewMediaList;

    /**
     * @var string[]
     */
    public $useCasesMediaList;

    /**
     * @var string[]
     */
    public $coverImgList;

    /**
     * @var string[]
     */
    public $caseVideoList;
    protected $_name = [
        'templateKey'            => 'templateKey',
        'name'                   => 'name',
        'simpleDesc'             => 'simpleDesc',
        'appDesc'                => 'appDesc',
        'appIcon'                => 'appIcon',
        'category'               => 'category',
        'providerName'           => 'providerName',
        'installTimes'           => 'installTimes',
        'industryLabelList'      => 'industryLabelList',
        'roleLabelList'          => 'roleLabelList',
        'adaptEnv'               => 'adaptEnv',
        'expUrl'                 => 'expUrl',
        'previewMediaList'       => 'previewMediaList',
        'mobilePreviewMediaList' => 'mobilePreviewMediaList',
        'useCasesMediaList'      => 'useCasesMediaList',
        'coverImgList'           => 'coverImgList',
        'caseVideoList'          => 'caseVideoList',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->templateKey) {
            $res['templateKey'] = $this->templateKey;
        }
        if (null !== $this->name) {
            $res['name'] = $this->name;
        }
        if (null !== $this->simpleDesc) {
            $res['simpleDesc'] = $this->simpleDesc;
        }
        if (null !== $this->appDesc) {
            $res['appDesc'] = $this->appDesc;
        }
        if (null !== $this->appIcon) {
            $res['appIcon'] = $this->appIcon;
        }
        if (null !== $this->category) {
            $res['category'] = $this->category;
        }
        if (null !== $this->providerName) {
            $res['providerName'] = $this->providerName;
        }
        if (null !== $this->installTimes) {
            $res['installTimes'] = $this->installTimes;
        }
        if (null !== $this->industryLabelList) {
            $res['industryLabelList'] = $this->industryLabelList;
        }
        if (null !== $this->roleLabelList) {
            $res['roleLabelList'] = $this->roleLabelList;
        }
        if (null !== $this->adaptEnv) {
            $res['adaptEnv'] = $this->adaptEnv;
        }
        if (null !== $this->expUrl) {
            $res['expUrl'] = $this->expUrl;
        }
        if (null !== $this->previewMediaList) {
            $res['previewMediaList'] = $this->previewMediaList;
        }
        if (null !== $this->mobilePreviewMediaList) {
            $res['mobilePreviewMediaList'] = $this->mobilePreviewMediaList;
        }
        if (null !== $this->useCasesMediaList) {
            $res['useCasesMediaList'] = $this->useCasesMediaList;
        }
        if (null !== $this->coverImgList) {
            $res['coverImgList'] = $this->coverImgList;
        }
        if (null !== $this->caseVideoList) {
            $res['caseVideoList'] = $this->caseVideoList;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return templateList
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['templateKey'])) {
            $model->templateKey = $map['templateKey'];
        }
        if (isset($map['name'])) {
            $model->name = $map['name'];
        }
        if (isset($map['simpleDesc'])) {
            $model->simpleDesc = $map['simpleDesc'];
        }
        if (isset($map['appDesc'])) {
            $model->appDesc = $map['appDesc'];
        }
        if (isset($map['appIcon'])) {
            $model->appIcon = $map['appIcon'];
        }
        if (isset($map['category'])) {
            $model->category = $map['category'];
        }
        if (isset($map['providerName'])) {
            $model->providerName = $map['providerName'];
        }
        if (isset($map['installTimes'])) {
            $model->installTimes = $map['installTimes'];
        }
        if (isset($map['industryLabelList'])) {
            if (!empty($map['industryLabelList'])) {
                $model->industryLabelList = $map['industryLabelList'];
            }
        }
        if (isset($map['roleLabelList'])) {
            if (!empty($map['roleLabelList'])) {
                $model->roleLabelList = $map['roleLabelList'];
            }
        }
        if (isset($map['adaptEnv'])) {
            if (!empty($map['adaptEnv'])) {
                $model->adaptEnv = $map['adaptEnv'];
            }
        }
        if (isset($map['expUrl'])) {
            $model->expUrl = $map['expUrl'];
        }
        if (isset($map['previewMediaList'])) {
            if (!empty($map['previewMediaList'])) {
                $model->previewMediaList = $map['previewMediaList'];
            }
        }
        if (isset($map['mobilePreviewMediaList'])) {
            if (!empty($map['mobilePreviewMediaList'])) {
                $model->mobilePreviewMediaList = $map['mobilePreviewMediaList'];
            }
        }
        if (isset($map['useCasesMediaList'])) {
            if (!empty($map['useCasesMediaList'])) {
                $model->useCasesMediaList = $map['useCasesMediaList'];
            }
        }
        if (isset($map['coverImgList'])) {
            if (!empty($map['coverImgList'])) {
                $model->coverImgList = $map['coverImgList'];
            }
        }
        if (isset($map['caseVideoList'])) {
            if (!empty($map['caseVideoList'])) {
                $model->caseVideoList = $map['caseVideoList'];
            }
        }

        return $model;
    }
}
