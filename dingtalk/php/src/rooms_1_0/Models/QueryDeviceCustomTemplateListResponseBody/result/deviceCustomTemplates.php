<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vrooms_1_0\Models\QueryDeviceCustomTemplateListResponseBody\result;

use AlibabaCloud\Tea\Model;

class deviceCustomTemplates extends Model
{
    /**
     * @var string[]
     */
    public $bgImageList;

    /**
     * @example 1
     *
     * @var int
     */
    public $bgType;

    /**
     * @example https://img.alicdn.com/imgextra/i2/O1CN01GWWCCR1y2D9D9EHej_!!6000000006520-2-tps-1920-470.png
     *
     * @var string
     */
    public $bgUrl;

    /**
     * @example 1
     *
     * @var int
     */
    public $confSubType;

    /**
     * @example 1
     *
     * @var int
     */
    public $confType;

    /**
     * @example dingc02f685fxxxx81c44ac5d6980864d335
     *
     * @var string
     */
    public $corpId;

    /**
     * @example 测试文本
     *
     * @var string
     */
    public $customDoc;

    /**
     * @example true：脱敏 false：不脱敏
     *
     * @var bool
     */
    public $desensitizeUserName;

    /**
     * @example true：隐藏 false：不隐藏
     *
     * @var bool
     */
    public $hideServerCodeWhenProjecting;

    /**
     * @example true：显示 false：不显示
     *
     * @var bool
     */
    public $instruction;

    /**
     * @example 1
     *
     * @var int
     */
    public $isPicTop;

    /**
     * @example logo
     *
     * @var string
     */
    public $logo;

    /**
     * @example 测试企业
     *
     * @var string
     */
    public $orgName;

    /**
     * @example 10
     *
     * @var int
     */
    public $picturePlayInterval;

    /**
     * @example true：展示 false：不展示
     *
     * @var bool
     */
    public $showCalendarCard;

    /**
     * @example true：展示 false：不展示
     *
     * @var bool
     */
    public $showCalendarTitle;

    /**
     * @example true：展示 false：不展示
     *
     * @var bool
     */
    public $showFunctionCard;

    /**
     * @example 89
     *
     * @var int
     */
    public $templateId;

    /**
     * @example 测试模板
     *
     * @var string
     */
    public $templateName;
    protected $_name = [
        'bgImageList' => 'bgImageList',
        'bgType' => 'bgType',
        'bgUrl' => 'bgUrl',
        'confSubType' => 'confSubType',
        'confType' => 'confType',
        'corpId' => 'corpId',
        'customDoc' => 'customDoc',
        'desensitizeUserName' => 'desensitizeUserName',
        'hideServerCodeWhenProjecting' => 'hideServerCodeWhenProjecting',
        'instruction' => 'instruction',
        'isPicTop' => 'isPicTop',
        'logo' => 'logo',
        'orgName' => 'orgName',
        'picturePlayInterval' => 'picturePlayInterval',
        'showCalendarCard' => 'showCalendarCard',
        'showCalendarTitle' => 'showCalendarTitle',
        'showFunctionCard' => 'showFunctionCard',
        'templateId' => 'templateId',
        'templateName' => 'templateName',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->bgImageList) {
            $res['bgImageList'] = $this->bgImageList;
        }
        if (null !== $this->bgType) {
            $res['bgType'] = $this->bgType;
        }
        if (null !== $this->bgUrl) {
            $res['bgUrl'] = $this->bgUrl;
        }
        if (null !== $this->confSubType) {
            $res['confSubType'] = $this->confSubType;
        }
        if (null !== $this->confType) {
            $res['confType'] = $this->confType;
        }
        if (null !== $this->corpId) {
            $res['corpId'] = $this->corpId;
        }
        if (null !== $this->customDoc) {
            $res['customDoc'] = $this->customDoc;
        }
        if (null !== $this->desensitizeUserName) {
            $res['desensitizeUserName'] = $this->desensitizeUserName;
        }
        if (null !== $this->hideServerCodeWhenProjecting) {
            $res['hideServerCodeWhenProjecting'] = $this->hideServerCodeWhenProjecting;
        }
        if (null !== $this->instruction) {
            $res['instruction'] = $this->instruction;
        }
        if (null !== $this->isPicTop) {
            $res['isPicTop'] = $this->isPicTop;
        }
        if (null !== $this->logo) {
            $res['logo'] = $this->logo;
        }
        if (null !== $this->orgName) {
            $res['orgName'] = $this->orgName;
        }
        if (null !== $this->picturePlayInterval) {
            $res['picturePlayInterval'] = $this->picturePlayInterval;
        }
        if (null !== $this->showCalendarCard) {
            $res['showCalendarCard'] = $this->showCalendarCard;
        }
        if (null !== $this->showCalendarTitle) {
            $res['showCalendarTitle'] = $this->showCalendarTitle;
        }
        if (null !== $this->showFunctionCard) {
            $res['showFunctionCard'] = $this->showFunctionCard;
        }
        if (null !== $this->templateId) {
            $res['templateId'] = $this->templateId;
        }
        if (null !== $this->templateName) {
            $res['templateName'] = $this->templateName;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return deviceCustomTemplates
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['bgImageList'])) {
            if (!empty($map['bgImageList'])) {
                $model->bgImageList = $map['bgImageList'];
            }
        }
        if (isset($map['bgType'])) {
            $model->bgType = $map['bgType'];
        }
        if (isset($map['bgUrl'])) {
            $model->bgUrl = $map['bgUrl'];
        }
        if (isset($map['confSubType'])) {
            $model->confSubType = $map['confSubType'];
        }
        if (isset($map['confType'])) {
            $model->confType = $map['confType'];
        }
        if (isset($map['corpId'])) {
            $model->corpId = $map['corpId'];
        }
        if (isset($map['customDoc'])) {
            $model->customDoc = $map['customDoc'];
        }
        if (isset($map['desensitizeUserName'])) {
            $model->desensitizeUserName = $map['desensitizeUserName'];
        }
        if (isset($map['hideServerCodeWhenProjecting'])) {
            $model->hideServerCodeWhenProjecting = $map['hideServerCodeWhenProjecting'];
        }
        if (isset($map['instruction'])) {
            $model->instruction = $map['instruction'];
        }
        if (isset($map['isPicTop'])) {
            $model->isPicTop = $map['isPicTop'];
        }
        if (isset($map['logo'])) {
            $model->logo = $map['logo'];
        }
        if (isset($map['orgName'])) {
            $model->orgName = $map['orgName'];
        }
        if (isset($map['picturePlayInterval'])) {
            $model->picturePlayInterval = $map['picturePlayInterval'];
        }
        if (isset($map['showCalendarCard'])) {
            $model->showCalendarCard = $map['showCalendarCard'];
        }
        if (isset($map['showCalendarTitle'])) {
            $model->showCalendarTitle = $map['showCalendarTitle'];
        }
        if (isset($map['showFunctionCard'])) {
            $model->showFunctionCard = $map['showFunctionCard'];
        }
        if (isset($map['templateId'])) {
            $model->templateId = $map['templateId'];
        }
        if (isset($map['templateName'])) {
            $model->templateName = $map['templateName'];
        }

        return $model;
    }
}
