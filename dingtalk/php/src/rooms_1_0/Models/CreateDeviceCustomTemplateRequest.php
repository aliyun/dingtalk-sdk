<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vrooms_1_0\Models;

use AlibabaCloud\Tea\Model;

class CreateDeviceCustomTemplateRequest extends Model
{
    /**
     * @var string[]
     */
    public $bgImgList;

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
     * @example 测试文本
     *
     * @var string
     */
    public $customDoc;

    /**
     * @var bool
     */
    public $desensitizeUserName;

    /**
     * @var string[]
     */
    public $deviceUnionIds;

    /**
     * @var int[]
     */
    public $groupIds;

    /**
     * @var bool
     */
    public $hideServerCodeWhenProjecting;

    /**
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
     * @var string[]
     */
    public $roomIds;

    /**
     * @var bool
     */
    public $showCalendarCard;

    /**
     * @var bool
     */
    public $showCalendarTitle;

    /**
     * @var bool
     */
    public $showFunctionCard;

    /**
     * @description This parameter is required.
     *
     * @example 测试模板
     *
     * @var string
     */
    public $templateName;
    protected $_name = [
        'bgImgList' => 'bgImgList',
        'bgType' => 'bgType',
        'bgUrl' => 'bgUrl',
        'customDoc' => 'customDoc',
        'desensitizeUserName' => 'desensitizeUserName',
        'deviceUnionIds' => 'deviceUnionIds',
        'groupIds' => 'groupIds',
        'hideServerCodeWhenProjecting' => 'hideServerCodeWhenProjecting',
        'instruction' => 'instruction',
        'isPicTop' => 'isPicTop',
        'logo' => 'logo',
        'orgName' => 'orgName',
        'picturePlayInterval' => 'picturePlayInterval',
        'roomIds' => 'roomIds',
        'showCalendarCard' => 'showCalendarCard',
        'showCalendarTitle' => 'showCalendarTitle',
        'showFunctionCard' => 'showFunctionCard',
        'templateName' => 'templateName',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->bgImgList) {
            $res['bgImgList'] = $this->bgImgList;
        }
        if (null !== $this->bgType) {
            $res['bgType'] = $this->bgType;
        }
        if (null !== $this->bgUrl) {
            $res['bgUrl'] = $this->bgUrl;
        }
        if (null !== $this->customDoc) {
            $res['customDoc'] = $this->customDoc;
        }
        if (null !== $this->desensitizeUserName) {
            $res['desensitizeUserName'] = $this->desensitizeUserName;
        }
        if (null !== $this->deviceUnionIds) {
            $res['deviceUnionIds'] = $this->deviceUnionIds;
        }
        if (null !== $this->groupIds) {
            $res['groupIds'] = $this->groupIds;
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
        if (null !== $this->roomIds) {
            $res['roomIds'] = $this->roomIds;
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
        if (null !== $this->templateName) {
            $res['templateName'] = $this->templateName;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return CreateDeviceCustomTemplateRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['bgImgList'])) {
            if (!empty($map['bgImgList'])) {
                $model->bgImgList = $map['bgImgList'];
            }
        }
        if (isset($map['bgType'])) {
            $model->bgType = $map['bgType'];
        }
        if (isset($map['bgUrl'])) {
            $model->bgUrl = $map['bgUrl'];
        }
        if (isset($map['customDoc'])) {
            $model->customDoc = $map['customDoc'];
        }
        if (isset($map['desensitizeUserName'])) {
            $model->desensitizeUserName = $map['desensitizeUserName'];
        }
        if (isset($map['deviceUnionIds'])) {
            if (!empty($map['deviceUnionIds'])) {
                $model->deviceUnionIds = $map['deviceUnionIds'];
            }
        }
        if (isset($map['groupIds'])) {
            if (!empty($map['groupIds'])) {
                $model->groupIds = $map['groupIds'];
            }
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
        if (isset($map['roomIds'])) {
            if (!empty($map['roomIds'])) {
                $model->roomIds = $map['roomIds'];
            }
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
        if (isset($map['templateName'])) {
            $model->templateName = $map['templateName'];
        }

        return $model;
    }
}
