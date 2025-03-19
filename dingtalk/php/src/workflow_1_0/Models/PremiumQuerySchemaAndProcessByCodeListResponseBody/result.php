<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models\PremiumQuerySchemaAndProcessByCodeListResponseBody;

use AlibabaCloud\Tea\Model;

class result extends Model
{
    /**
     * @example ding123
     *
     * @var string
     */
    public $appUuid;

    /**
     * @example hrm.xxx
     *
     * @var string
     */
    public $bizCategoryId;

    /**
     * @example 1638326995000
     *
     * @var int
     */
    public $createTime;

    /**
     * @example userId123
     *
     * @var string
     */
    public $creatorUserId;

    /**
     * @example FORM-28215C3E-00E3-4118-xxxx-4091F828AF2F
     *
     * @var string
     */
    public $formUuid;

    /**
     * @example https//:xxx
     *
     * @var string
     */
    public $icon;

    /**
     * @example 模板描述1
     *
     * @var string
     */
    public $memo;

    /**
     * @example userId123
     *
     * @var string
     */
    public $modifierUserId;

    /**
     * @example 1638326995000
     *
     * @var int
     */
    public $modifyTime;

    /**
     * @example 示例模板
     *
     * @var string
     */
    public $name;

    /**
     * @example PROC-17428B8C-6C60-470E-xxxx-64F1037AE067
     *
     * @var string
     */
    public $processCode;

    /**
     * @example {\"name\":\"发起人\",\"type\":\"start\",\"nodeId\":\"sid-startevent\",\"childNode\":{\"name\":\"审批人\",\"prevId\":\"sid-startevent\",\"type\":\"approver\",\"nodeId\":\"sid-1234_5678\",\"properties\":{\"activateType\":\"ONE_BY_ONE\",\"approvalType\":\"MANUAL\",\"actionerRules\":[{\"select\":[\"allStaff\"],\"range\":{\"approvals\":[],\"labels\":[]},\"type\":\"target_select\",\"key\":\"manual_sid-1234_5678_30a8_b373\",\"multi\":1}],\"agreeAll\":false},\"childNode\":{\"name\":\"抄送人\",\"prevId\":\"sid-1234_5678\",\"type\":\"notifier\",\"nodeId\":\"9955_7e43\",\"properties\":{\"actionerRules\":[{\"select\":[\"allStaff\"],\"range\":{},\"type\":\"target_select\",\"key\":\"manual_9955_7e43_0c96_39d8\",\"multi\":1}]}}}}
     *
     * @var string
     */
    public $processConfig;

    /**
     * @var int
     */
    public $processId;

    /**
     * @example {\"commentHiddenForProposer\":\"\",\"commentRequired\":\"\",\"icon\":\"timefades#red\",\"commentDescription\":\"\",\"description\":\"支持地址控件\",\"title\":\"官方OA审批-POP-2025-0109\",\"items\":[{\"componentName\":\"TimeAndLocationField\",\"props\":{\"label\":[\"当前时间\",\"当前地点\"],\"id\":\"TimeAndLocationField_1CVHM5TIIWR9C\",\"required\":false}},{\"componentName\":\"TextField\",\"props\":{\"placeholder\":\"请输入\",\"label\":\"单行输入框\",\"id\":\"TextField_17EZKEGSOCTC0\",\"required\":false}}]}
     *
     * @var string
     */
    public $schemaContent;

    /**
     * @example PUBLISHED
     *
     * @var string
     */
    public $status;
    protected $_name = [
        'appUuid' => 'appUuid',
        'bizCategoryId' => 'bizCategoryId',
        'createTime' => 'createTime',
        'creatorUserId' => 'creatorUserId',
        'formUuid' => 'formUuid',
        'icon' => 'icon',
        'memo' => 'memo',
        'modifierUserId' => 'modifierUserId',
        'modifyTime' => 'modifyTime',
        'name' => 'name',
        'processCode' => 'processCode',
        'processConfig' => 'processConfig',
        'processId' => 'processId',
        'schemaContent' => 'schemaContent',
        'status' => 'status',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->appUuid) {
            $res['appUuid'] = $this->appUuid;
        }
        if (null !== $this->bizCategoryId) {
            $res['bizCategoryId'] = $this->bizCategoryId;
        }
        if (null !== $this->createTime) {
            $res['createTime'] = $this->createTime;
        }
        if (null !== $this->creatorUserId) {
            $res['creatorUserId'] = $this->creatorUserId;
        }
        if (null !== $this->formUuid) {
            $res['formUuid'] = $this->formUuid;
        }
        if (null !== $this->icon) {
            $res['icon'] = $this->icon;
        }
        if (null !== $this->memo) {
            $res['memo'] = $this->memo;
        }
        if (null !== $this->modifierUserId) {
            $res['modifierUserId'] = $this->modifierUserId;
        }
        if (null !== $this->modifyTime) {
            $res['modifyTime'] = $this->modifyTime;
        }
        if (null !== $this->name) {
            $res['name'] = $this->name;
        }
        if (null !== $this->processCode) {
            $res['processCode'] = $this->processCode;
        }
        if (null !== $this->processConfig) {
            $res['processConfig'] = $this->processConfig;
        }
        if (null !== $this->processId) {
            $res['processId'] = $this->processId;
        }
        if (null !== $this->schemaContent) {
            $res['schemaContent'] = $this->schemaContent;
        }
        if (null !== $this->status) {
            $res['status'] = $this->status;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return result
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['appUuid'])) {
            $model->appUuid = $map['appUuid'];
        }
        if (isset($map['bizCategoryId'])) {
            $model->bizCategoryId = $map['bizCategoryId'];
        }
        if (isset($map['createTime'])) {
            $model->createTime = $map['createTime'];
        }
        if (isset($map['creatorUserId'])) {
            $model->creatorUserId = $map['creatorUserId'];
        }
        if (isset($map['formUuid'])) {
            $model->formUuid = $map['formUuid'];
        }
        if (isset($map['icon'])) {
            $model->icon = $map['icon'];
        }
        if (isset($map['memo'])) {
            $model->memo = $map['memo'];
        }
        if (isset($map['modifierUserId'])) {
            $model->modifierUserId = $map['modifierUserId'];
        }
        if (isset($map['modifyTime'])) {
            $model->modifyTime = $map['modifyTime'];
        }
        if (isset($map['name'])) {
            $model->name = $map['name'];
        }
        if (isset($map['processCode'])) {
            $model->processCode = $map['processCode'];
        }
        if (isset($map['processConfig'])) {
            $model->processConfig = $map['processConfig'];
        }
        if (isset($map['processId'])) {
            $model->processId = $map['processId'];
        }
        if (isset($map['schemaContent'])) {
            $model->schemaContent = $map['schemaContent'];
        }
        if (isset($map['status'])) {
            $model->status = $map['status'];
        }

        return $model;
    }
}
