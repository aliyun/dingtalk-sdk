<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vapaas_1_0\Models\BatchUpdateTemplateRequest;

use AlibabaCloud\Tea\Model;

class templateList extends Model
{
    /**
     * @description category
     *
     * @var string
     */
    public $categoryCode;

    /**
     * @description mobilePreviewMediaList
     *
     * @var string[]
     */
    public $mobilePreviewMediaList;

    /**
     * @description templateKey
     *
     * @var string
     */
    public $templateKey;

    /**
     * @description adaptEnv
     *
     * @var string[]
     */
    public $adaptEnv;

    /**
     * @description appDesc
     *
     * @var string
     */
    public $appDesc;

    /**
     * @description name
     *
     * @var string
     */
    public $name;

    /**
     * @description providerName
     *
     * @var string
     */
    public $providerName;

    /**
     * @description coverImgList
     *
     * @var string[]
     */
    public $coverImgList;

    /**
     * @description roleLabelList
     *
     * @var string[]
     */
    public $roleLabelList;

    /**
     * @description previewMediaList
     *
     * @var string[]
     */
    public $previewMediaList;

    /**
     * @description simpleDesc
     *
     * @var string
     */
    public $simpleDesc;

    /**
     * @description caseVideoList
     *
     * @var string[]
     */
    public $caseVideoList;

    /**
     * @description industryLabelList
     *
     * @var string[]
     */
    public $industryLabelList;

    /**
     * @description appIcon
     *
     * @var string
     */
    public $appIcon;

    /**
     * @description useCasesMediaList
     *
     * @var string[]
     */
    public $useCasesMediaList;

    /**
     * @description expUrl
     *
     * @var string
     */
    public $expUrl;
    protected $_name = [
        'categoryCode'           => 'categoryCode',
        'mobilePreviewMediaList' => 'mobilePreviewMediaList',
        'templateKey'            => 'templateKey',
        'adaptEnv'               => 'adaptEnv',
        'appDesc'                => 'appDesc',
        'name'                   => 'name',
        'providerName'           => 'providerName',
        'coverImgList'           => 'coverImgList',
        'roleLabelList'          => 'roleLabelList',
        'previewMediaList'       => 'previewMediaList',
        'simpleDesc'             => 'simpleDesc',
        'caseVideoList'          => 'caseVideoList',
        'industryLabelList'      => 'industryLabelList',
        'appIcon'                => 'appIcon',
        'useCasesMediaList'      => 'useCasesMediaList',
        'expUrl'                 => 'expUrl',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->categoryCode) {
            $res['categoryCode'] = $this->categoryCode;
        }
        if (null !== $this->mobilePreviewMediaList) {
            $res['mobilePreviewMediaList'] = $this->mobilePreviewMediaList;
        }
        if (null !== $this->templateKey) {
            $res['templateKey'] = $this->templateKey;
        }
        if (null !== $this->adaptEnv) {
            $res['adaptEnv'] = $this->adaptEnv;
        }
        if (null !== $this->appDesc) {
            $res['appDesc'] = $this->appDesc;
        }
        if (null !== $this->name) {
            $res['name'] = $this->name;
        }
        if (null !== $this->providerName) {
            $res['providerName'] = $this->providerName;
        }
        if (null !== $this->coverImgList) {
            $res['coverImgList'] = $this->coverImgList;
        }
        if (null !== $this->roleLabelList) {
            $res['roleLabelList'] = $this->roleLabelList;
        }
        if (null !== $this->previewMediaList) {
            $res['previewMediaList'] = $this->previewMediaList;
        }
        if (null !== $this->simpleDesc) {
            $res['simpleDesc'] = $this->simpleDesc;
        }
        if (null !== $this->caseVideoList) {
            $res['caseVideoList'] = $this->caseVideoList;
        }
        if (null !== $this->industryLabelList) {
            $res['industryLabelList'] = $this->industryLabelList;
        }
        if (null !== $this->appIcon) {
            $res['appIcon'] = $this->appIcon;
        }
        if (null !== $this->useCasesMediaList) {
            $res['useCasesMediaList'] = $this->useCasesMediaList;
        }
        if (null !== $this->expUrl) {
            $res['expUrl'] = $this->expUrl;
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
        if (isset($map['categoryCode'])) {
            $model->categoryCode = $map['categoryCode'];
        }
        if (isset($map['mobilePreviewMediaList'])) {
            if (!empty($map['mobilePreviewMediaList'])) {
                $model->mobilePreviewMediaList = $map['mobilePreviewMediaList'];
            }
        }
        if (isset($map['templateKey'])) {
            $model->templateKey = $map['templateKey'];
        }
        if (isset($map['adaptEnv'])) {
            if (!empty($map['adaptEnv'])) {
                $model->adaptEnv = $map['adaptEnv'];
            }
        }
        if (isset($map['appDesc'])) {
            $model->appDesc = $map['appDesc'];
        }
        if (isset($map['name'])) {
            $model->name = $map['name'];
        }
        if (isset($map['providerName'])) {
            $model->providerName = $map['providerName'];
        }
        if (isset($map['coverImgList'])) {
            if (!empty($map['coverImgList'])) {
                $model->coverImgList = $map['coverImgList'];
            }
        }
        if (isset($map['roleLabelList'])) {
            if (!empty($map['roleLabelList'])) {
                $model->roleLabelList = $map['roleLabelList'];
            }
        }
        if (isset($map['previewMediaList'])) {
            if (!empty($map['previewMediaList'])) {
                $model->previewMediaList = $map['previewMediaList'];
            }
        }
        if (isset($map['simpleDesc'])) {
            $model->simpleDesc = $map['simpleDesc'];
        }
        if (isset($map['caseVideoList'])) {
            if (!empty($map['caseVideoList'])) {
                $model->caseVideoList = $map['caseVideoList'];
            }
        }
        if (isset($map['industryLabelList'])) {
            if (!empty($map['industryLabelList'])) {
                $model->industryLabelList = $map['industryLabelList'];
            }
        }
        if (isset($map['appIcon'])) {
            $model->appIcon = $map['appIcon'];
        }
        if (isset($map['useCasesMediaList'])) {
            if (!empty($map['useCasesMediaList'])) {
                $model->useCasesMediaList = $map['useCasesMediaList'];
            }
        }
        if (isset($map['expUrl'])) {
            $model->expUrl = $map['expUrl'];
        }

        return $model;
    }
}
