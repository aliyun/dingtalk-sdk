<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\QueryTemplateInfoResponseBody\appInfo;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\QueryTemplateInfoResponseBody\grayInfo;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\QueryTemplateInfoResponseBody\groupSettingList;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\QueryTemplateInfoResponseBody\parentTemplateDetailVO;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\QueryTemplateInfoResponseBody\templateIntroduction;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\QueryTemplateInfoResponseBody\templateVisibility;
use AlibabaCloud\Tea\Model;

class QueryTemplateInfoResponseBody extends Model
{
    /**
     * @var int
     */
    public $abilitySwitch;

    /**
     * @var appInfo
     */
    public $appInfo;

    /**
     * @var string[]
     */
    public $conversationScope;

    /**
     * @var int
     */
    public $createAt;

    /**
     * @var string
     */
    public $description;

    /**
     * @var string[]
     */
    public $grayConversationIds;

    /**
     * @var grayInfo
     */
    public $grayInfo;

    /**
     * @var string
     */
    public $grayTemplateId;

    /**
     * @var groupSettingList[]
     */
    public $groupSettingList;

    /**
     * @var string
     */
    public $iconMediaId;

    /**
     * @var int
     */
    public $modifiedAt;

    /**
     * @var int
     */
    public $modifyOrderId;

    /**
     * @var int
     */
    public $modifyStatus;

    /**
     * @var parentTemplateDetailVO
     */
    public $parentTemplateDetailVO;

    /**
     * @var string
     */
    public $publishSubState;

    /**
     * @var string[]
     */
    public $robotTemplateList;

    /**
     * @var int
     */
    public $status;

    /**
     * @var string
     */
    public $templateId;

    /**
     * @var templateIntroduction
     */
    public $templateIntroduction;

    /**
     * @var string
     */
    public $templateName;

    /**
     * @var int
     */
    public $templateType;

    /**
     * @var templateVisibility
     */
    public $templateVisibility;

    /**
     * @var string[]
     */
    public $toolbarPluginList;

    /**
     * @var int
     */
    public $version;
    protected $_name = [
        'abilitySwitch' => 'abilitySwitch',
        'appInfo' => 'appInfo',
        'conversationScope' => 'conversationScope',
        'createAt' => 'createAt',
        'description' => 'description',
        'grayConversationIds' => 'grayConversationIds',
        'grayInfo' => 'grayInfo',
        'grayTemplateId' => 'grayTemplateId',
        'groupSettingList' => 'groupSettingList',
        'iconMediaId' => 'iconMediaId',
        'modifiedAt' => 'modifiedAt',
        'modifyOrderId' => 'modifyOrderId',
        'modifyStatus' => 'modifyStatus',
        'parentTemplateDetailVO' => 'parentTemplateDetailVO',
        'publishSubState' => 'publishSubState',
        'robotTemplateList' => 'robotTemplateList',
        'status' => 'status',
        'templateId' => 'templateId',
        'templateIntroduction' => 'templateIntroduction',
        'templateName' => 'templateName',
        'templateType' => 'templateType',
        'templateVisibility' => 'templateVisibility',
        'toolbarPluginList' => 'toolbarPluginList',
        'version' => 'version',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->abilitySwitch) {
            $res['abilitySwitch'] = $this->abilitySwitch;
        }
        if (null !== $this->appInfo) {
            $res['appInfo'] = null !== $this->appInfo ? $this->appInfo->toMap() : null;
        }
        if (null !== $this->conversationScope) {
            $res['conversationScope'] = $this->conversationScope;
        }
        if (null !== $this->createAt) {
            $res['createAt'] = $this->createAt;
        }
        if (null !== $this->description) {
            $res['description'] = $this->description;
        }
        if (null !== $this->grayConversationIds) {
            $res['grayConversationIds'] = $this->grayConversationIds;
        }
        if (null !== $this->grayInfo) {
            $res['grayInfo'] = null !== $this->grayInfo ? $this->grayInfo->toMap() : null;
        }
        if (null !== $this->grayTemplateId) {
            $res['grayTemplateId'] = $this->grayTemplateId;
        }
        if (null !== $this->groupSettingList) {
            $res['groupSettingList'] = [];
            if (null !== $this->groupSettingList && \is_array($this->groupSettingList)) {
                $n = 0;
                foreach ($this->groupSettingList as $item) {
                    $res['groupSettingList'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->iconMediaId) {
            $res['iconMediaId'] = $this->iconMediaId;
        }
        if (null !== $this->modifiedAt) {
            $res['modifiedAt'] = $this->modifiedAt;
        }
        if (null !== $this->modifyOrderId) {
            $res['modifyOrderId'] = $this->modifyOrderId;
        }
        if (null !== $this->modifyStatus) {
            $res['modifyStatus'] = $this->modifyStatus;
        }
        if (null !== $this->parentTemplateDetailVO) {
            $res['parentTemplateDetailVO'] = null !== $this->parentTemplateDetailVO ? $this->parentTemplateDetailVO->toMap() : null;
        }
        if (null !== $this->publishSubState) {
            $res['publishSubState'] = $this->publishSubState;
        }
        if (null !== $this->robotTemplateList) {
            $res['robotTemplateList'] = $this->robotTemplateList;
        }
        if (null !== $this->status) {
            $res['status'] = $this->status;
        }
        if (null !== $this->templateId) {
            $res['templateId'] = $this->templateId;
        }
        if (null !== $this->templateIntroduction) {
            $res['templateIntroduction'] = null !== $this->templateIntroduction ? $this->templateIntroduction->toMap() : null;
        }
        if (null !== $this->templateName) {
            $res['templateName'] = $this->templateName;
        }
        if (null !== $this->templateType) {
            $res['templateType'] = $this->templateType;
        }
        if (null !== $this->templateVisibility) {
            $res['templateVisibility'] = null !== $this->templateVisibility ? $this->templateVisibility->toMap() : null;
        }
        if (null !== $this->toolbarPluginList) {
            $res['toolbarPluginList'] = $this->toolbarPluginList;
        }
        if (null !== $this->version) {
            $res['version'] = $this->version;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return QueryTemplateInfoResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['abilitySwitch'])) {
            $model->abilitySwitch = $map['abilitySwitch'];
        }
        if (isset($map['appInfo'])) {
            $model->appInfo = appInfo::fromMap($map['appInfo']);
        }
        if (isset($map['conversationScope'])) {
            if (!empty($map['conversationScope'])) {
                $model->conversationScope = $map['conversationScope'];
            }
        }
        if (isset($map['createAt'])) {
            $model->createAt = $map['createAt'];
        }
        if (isset($map['description'])) {
            $model->description = $map['description'];
        }
        if (isset($map['grayConversationIds'])) {
            if (!empty($map['grayConversationIds'])) {
                $model->grayConversationIds = $map['grayConversationIds'];
            }
        }
        if (isset($map['grayInfo'])) {
            $model->grayInfo = grayInfo::fromMap($map['grayInfo']);
        }
        if (isset($map['grayTemplateId'])) {
            $model->grayTemplateId = $map['grayTemplateId'];
        }
        if (isset($map['groupSettingList'])) {
            if (!empty($map['groupSettingList'])) {
                $model->groupSettingList = [];
                $n = 0;
                foreach ($map['groupSettingList'] as $item) {
                    $model->groupSettingList[$n++] = null !== $item ? groupSettingList::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['iconMediaId'])) {
            $model->iconMediaId = $map['iconMediaId'];
        }
        if (isset($map['modifiedAt'])) {
            $model->modifiedAt = $map['modifiedAt'];
        }
        if (isset($map['modifyOrderId'])) {
            $model->modifyOrderId = $map['modifyOrderId'];
        }
        if (isset($map['modifyStatus'])) {
            $model->modifyStatus = $map['modifyStatus'];
        }
        if (isset($map['parentTemplateDetailVO'])) {
            $model->parentTemplateDetailVO = parentTemplateDetailVO::fromMap($map['parentTemplateDetailVO']);
        }
        if (isset($map['publishSubState'])) {
            $model->publishSubState = $map['publishSubState'];
        }
        if (isset($map['robotTemplateList'])) {
            if (!empty($map['robotTemplateList'])) {
                $model->robotTemplateList = $map['robotTemplateList'];
            }
        }
        if (isset($map['status'])) {
            $model->status = $map['status'];
        }
        if (isset($map['templateId'])) {
            $model->templateId = $map['templateId'];
        }
        if (isset($map['templateIntroduction'])) {
            $model->templateIntroduction = templateIntroduction::fromMap($map['templateIntroduction']);
        }
        if (isset($map['templateName'])) {
            $model->templateName = $map['templateName'];
        }
        if (isset($map['templateType'])) {
            $model->templateType = $map['templateType'];
        }
        if (isset($map['templateVisibility'])) {
            $model->templateVisibility = templateVisibility::fromMap($map['templateVisibility']);
        }
        if (isset($map['toolbarPluginList'])) {
            if (!empty($map['toolbarPluginList'])) {
                $model->toolbarPluginList = $map['toolbarPluginList'];
            }
        }
        if (isset($map['version'])) {
            $model->version = $map['version'];
        }

        return $model;
    }
}
