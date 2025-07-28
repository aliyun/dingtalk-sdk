<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vapaas_1_0\Models\BatchQueryByTemplateKeyResponseBody;

use AlibabaCloud\Tea\Model;

class templateList extends Model
{
    /**
     * @description This parameter is required.
     *
     * @var string[]
     */
    public $adaptEnv;

    /**
     * @description This parameter is required.
     *
     * @example 测试用
     *
     * @var string
     */
    public $appDesc;

    /**
     * @description This parameter is required.
     *
     * @example @lALPDe7s2JOuoyjNBaDNCgA
     *
     * @var string
     */
    public $appIcon;

    /**
     * @description This parameter is required.
     *
     * @var string[]
     */
    public $caseVideoList;

    /**
     * @description This parameter is required.
     *
     * @example template_category
     *
     * @var string
     */
    public $category;

    /**
     * @description This parameter is required.
     *
     * @var string[]
     */
    public $coverImgList;

    /**
     * @description This parameter is required.
     *
     * @example http://www.baidu.com
     *
     * @var string
     */
    public $expUrl;

    /**
     * @description This parameter is required.
     *
     * @var string[]
     */
    public $industryLabelList;

    /**
     * @description This parameter is required.
     *
     * @example 100
     *
     * @var float
     */
    public $installTimes;

    /**
     * @description This parameter is required.
     *
     * @var string[]
     */
    public $mobilePreviewMediaList;

    /**
     * @description This parameter is required.
     *
     * @example 测试用
     *
     * @var string
     */
    public $name;

    /**
     * @description This parameter is required.
     *
     * @var string[]
     */
    public $previewMediaList;

    /**
     * @description This parameter is required.
     *
     * @example 小明
     *
     * @var string
     */
    public $providerName;

    /**
     * @description This parameter is required.
     *
     * @var string[]
     */
    public $roleLabelList;

    /**
     * @description This parameter is required.
     *
     * @example 测试用
     *
     * @var string
     */
    public $simpleDesc;

    /**
     * @description This parameter is required.
     *
     * @example template_key
     *
     * @var string
     */
    public $templateKey;

    /**
     * @description This parameter is required.
     *
     * @var string[]
     */
    public $useCasesMediaList;
    protected $_name = [
        'adaptEnv' => 'adaptEnv',
        'appDesc' => 'appDesc',
        'appIcon' => 'appIcon',
        'caseVideoList' => 'caseVideoList',
        'category' => 'category',
        'coverImgList' => 'coverImgList',
        'expUrl' => 'expUrl',
        'industryLabelList' => 'industryLabelList',
        'installTimes' => 'installTimes',
        'mobilePreviewMediaList' => 'mobilePreviewMediaList',
        'name' => 'name',
        'previewMediaList' => 'previewMediaList',
        'providerName' => 'providerName',
        'roleLabelList' => 'roleLabelList',
        'simpleDesc' => 'simpleDesc',
        'templateKey' => 'templateKey',
        'useCasesMediaList' => 'useCasesMediaList',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->adaptEnv) {
            $res['adaptEnv'] = $this->adaptEnv;
        }
        if (null !== $this->appDesc) {
            $res['appDesc'] = $this->appDesc;
        }
        if (null !== $this->appIcon) {
            $res['appIcon'] = $this->appIcon;
        }
        if (null !== $this->caseVideoList) {
            $res['caseVideoList'] = $this->caseVideoList;
        }
        if (null !== $this->category) {
            $res['category'] = $this->category;
        }
        if (null !== $this->coverImgList) {
            $res['coverImgList'] = $this->coverImgList;
        }
        if (null !== $this->expUrl) {
            $res['expUrl'] = $this->expUrl;
        }
        if (null !== $this->industryLabelList) {
            $res['industryLabelList'] = $this->industryLabelList;
        }
        if (null !== $this->installTimes) {
            $res['installTimes'] = $this->installTimes;
        }
        if (null !== $this->mobilePreviewMediaList) {
            $res['mobilePreviewMediaList'] = $this->mobilePreviewMediaList;
        }
        if (null !== $this->name) {
            $res['name'] = $this->name;
        }
        if (null !== $this->previewMediaList) {
            $res['previewMediaList'] = $this->previewMediaList;
        }
        if (null !== $this->providerName) {
            $res['providerName'] = $this->providerName;
        }
        if (null !== $this->roleLabelList) {
            $res['roleLabelList'] = $this->roleLabelList;
        }
        if (null !== $this->simpleDesc) {
            $res['simpleDesc'] = $this->simpleDesc;
        }
        if (null !== $this->templateKey) {
            $res['templateKey'] = $this->templateKey;
        }
        if (null !== $this->useCasesMediaList) {
            $res['useCasesMediaList'] = $this->useCasesMediaList;
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
        if (isset($map['adaptEnv'])) {
            if (!empty($map['adaptEnv'])) {
                $model->adaptEnv = $map['adaptEnv'];
            }
        }
        if (isset($map['appDesc'])) {
            $model->appDesc = $map['appDesc'];
        }
        if (isset($map['appIcon'])) {
            $model->appIcon = $map['appIcon'];
        }
        if (isset($map['caseVideoList'])) {
            if (!empty($map['caseVideoList'])) {
                $model->caseVideoList = $map['caseVideoList'];
            }
        }
        if (isset($map['category'])) {
            $model->category = $map['category'];
        }
        if (isset($map['coverImgList'])) {
            if (!empty($map['coverImgList'])) {
                $model->coverImgList = $map['coverImgList'];
            }
        }
        if (isset($map['expUrl'])) {
            $model->expUrl = $map['expUrl'];
        }
        if (isset($map['industryLabelList'])) {
            if (!empty($map['industryLabelList'])) {
                $model->industryLabelList = $map['industryLabelList'];
            }
        }
        if (isset($map['installTimes'])) {
            $model->installTimes = $map['installTimes'];
        }
        if (isset($map['mobilePreviewMediaList'])) {
            if (!empty($map['mobilePreviewMediaList'])) {
                $model->mobilePreviewMediaList = $map['mobilePreviewMediaList'];
            }
        }
        if (isset($map['name'])) {
            $model->name = $map['name'];
        }
        if (isset($map['previewMediaList'])) {
            if (!empty($map['previewMediaList'])) {
                $model->previewMediaList = $map['previewMediaList'];
            }
        }
        if (isset($map['providerName'])) {
            $model->providerName = $map['providerName'];
        }
        if (isset($map['roleLabelList'])) {
            if (!empty($map['roleLabelList'])) {
                $model->roleLabelList = $map['roleLabelList'];
            }
        }
        if (isset($map['simpleDesc'])) {
            $model->simpleDesc = $map['simpleDesc'];
        }
        if (isset($map['templateKey'])) {
            $model->templateKey = $map['templateKey'];
        }
        if (isset($map['useCasesMediaList'])) {
            if (!empty($map['useCasesMediaList'])) {
                $model->useCasesMediaList = $map['useCasesMediaList'];
            }
        }

        return $model;
    }
}
