<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\ListAuditLogResponseBody;

use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\ListAuditLogResponseBody\list_\docMemberList;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\ListAuditLogResponseBody\list_\docReceiverList;
use AlibabaCloud\Tea\Model;

class list_ extends Model
{
    /**
     * @description 操作类型
     *
     * @var int
     */
    public $action;

    /**
     * @description 操作类型翻译值
     *
     * @var string
     */
    public $actionView;

    /**
     * @description 文件id
     *
     * @var string
     */
    public $bizId;

    /**
     * @description 接收成员列表，仅分享文档返回
     *
     * @var docMemberList[]
     */
    public $docMemberList;

    /**
     * @description 成员授权列表，仅文档授权返回
     *
     * @var docReceiverList[]
     */
    public $docReceiverList;

    /**
     * @description 记录生成时间，unix时间戳，单位ms
     *
     * @var int
     */
    public $gmtCreate;

    /**
     * @description 记录修改时间，unix时间戳，单位ms
     *
     * @var int
     */
    public $gmtModified;

    /**
     * @description 操作机器ip
     *
     * @var string
     */
    public $ipAddress;

    /**
     * @description 操作来源空间
     *
     * @var int
     */
    public $operateModule;

    /**
     * @description 操作来源翻译值
     *
     * @var string
     */
    public $operateModuleView;

    /**
     * @description 用户昵称
     *
     * @var string
     */
    public $operatorName;

    /**
     * @description 文件所属组织名称
     *
     * @var string
     */
    public $orgName;

    /**
     * @description 操作端
     *
     * @var int
     */
    public $platform;

    /**
     * @description 操作端翻译值
     *
     * @var string
     */
    public $platformView;

    /**
     * @description 用户姓名
     *
     * @var string
     */
    public $realName;

    /**
     * @description 文件接收方名称
     *
     * @var string
     */
    public $receiverName;

    /**
     * @description 文件接收方类型
     *
     * @var int
     */
    public $receiverType;

    /**
     * @description 文件接收方类型翻译值
     *
     * @var string
     */
    public $receiverTypeView;

    /**
     * @description test.docx
     *
     * @var string
     */
    public $resource;

    /**
     * @description 文件类型
     *
     * @var string
     */
    public $resourceExtension;

    /**
     * @description 文件大小
     *
     * @var int
     */
    public $resourceSize;

    /**
     * @description 记录状态
     *
     * @var int
     */
    public $status;

    /**
     * @description 空间id
     *
     * @var int
     */
    public $targetSpaceId;

    /**
     * @description 员工的userId
     *
     * @var string
     */
    public $userId;
    protected $_name = [
        'action'            => 'action',
        'actionView'        => 'actionView',
        'bizId'             => 'bizId',
        'docMemberList'     => 'docMemberList',
        'docReceiverList'   => 'docReceiverList',
        'gmtCreate'         => 'gmtCreate',
        'gmtModified'       => 'gmtModified',
        'ipAddress'         => 'ipAddress',
        'operateModule'     => 'operateModule',
        'operateModuleView' => 'operateModuleView',
        'operatorName'      => 'operatorName',
        'orgName'           => 'orgName',
        'platform'          => 'platform',
        'platformView'      => 'platformView',
        'realName'          => 'realName',
        'receiverName'      => 'receiverName',
        'receiverType'      => 'receiverType',
        'receiverTypeView'  => 'receiverTypeView',
        'resource'          => 'resource',
        'resourceExtension' => 'resourceExtension',
        'resourceSize'      => 'resourceSize',
        'status'            => 'status',
        'targetSpaceId'     => 'targetSpaceId',
        'userId'            => 'userId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->action) {
            $res['action'] = $this->action;
        }
        if (null !== $this->actionView) {
            $res['actionView'] = $this->actionView;
        }
        if (null !== $this->bizId) {
            $res['bizId'] = $this->bizId;
        }
        if (null !== $this->docMemberList) {
            $res['docMemberList'] = [];
            if (null !== $this->docMemberList && \is_array($this->docMemberList)) {
                $n = 0;
                foreach ($this->docMemberList as $item) {
                    $res['docMemberList'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->docReceiverList) {
            $res['docReceiverList'] = [];
            if (null !== $this->docReceiverList && \is_array($this->docReceiverList)) {
                $n = 0;
                foreach ($this->docReceiverList as $item) {
                    $res['docReceiverList'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->gmtCreate) {
            $res['gmtCreate'] = $this->gmtCreate;
        }
        if (null !== $this->gmtModified) {
            $res['gmtModified'] = $this->gmtModified;
        }
        if (null !== $this->ipAddress) {
            $res['ipAddress'] = $this->ipAddress;
        }
        if (null !== $this->operateModule) {
            $res['operateModule'] = $this->operateModule;
        }
        if (null !== $this->operateModuleView) {
            $res['operateModuleView'] = $this->operateModuleView;
        }
        if (null !== $this->operatorName) {
            $res['operatorName'] = $this->operatorName;
        }
        if (null !== $this->orgName) {
            $res['orgName'] = $this->orgName;
        }
        if (null !== $this->platform) {
            $res['platform'] = $this->platform;
        }
        if (null !== $this->platformView) {
            $res['platformView'] = $this->platformView;
        }
        if (null !== $this->realName) {
            $res['realName'] = $this->realName;
        }
        if (null !== $this->receiverName) {
            $res['receiverName'] = $this->receiverName;
        }
        if (null !== $this->receiverType) {
            $res['receiverType'] = $this->receiverType;
        }
        if (null !== $this->receiverTypeView) {
            $res['receiverTypeView'] = $this->receiverTypeView;
        }
        if (null !== $this->resource) {
            $res['resource'] = $this->resource;
        }
        if (null !== $this->resourceExtension) {
            $res['resourceExtension'] = $this->resourceExtension;
        }
        if (null !== $this->resourceSize) {
            $res['resourceSize'] = $this->resourceSize;
        }
        if (null !== $this->status) {
            $res['status'] = $this->status;
        }
        if (null !== $this->targetSpaceId) {
            $res['targetSpaceId'] = $this->targetSpaceId;
        }
        if (null !== $this->userId) {
            $res['userId'] = $this->userId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return list_
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['action'])) {
            $model->action = $map['action'];
        }
        if (isset($map['actionView'])) {
            $model->actionView = $map['actionView'];
        }
        if (isset($map['bizId'])) {
            $model->bizId = $map['bizId'];
        }
        if (isset($map['docMemberList'])) {
            if (!empty($map['docMemberList'])) {
                $model->docMemberList = [];
                $n                    = 0;
                foreach ($map['docMemberList'] as $item) {
                    $model->docMemberList[$n++] = null !== $item ? docMemberList::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['docReceiverList'])) {
            if (!empty($map['docReceiverList'])) {
                $model->docReceiverList = [];
                $n                      = 0;
                foreach ($map['docReceiverList'] as $item) {
                    $model->docReceiverList[$n++] = null !== $item ? docReceiverList::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['gmtCreate'])) {
            $model->gmtCreate = $map['gmtCreate'];
        }
        if (isset($map['gmtModified'])) {
            $model->gmtModified = $map['gmtModified'];
        }
        if (isset($map['ipAddress'])) {
            $model->ipAddress = $map['ipAddress'];
        }
        if (isset($map['operateModule'])) {
            $model->operateModule = $map['operateModule'];
        }
        if (isset($map['operateModuleView'])) {
            $model->operateModuleView = $map['operateModuleView'];
        }
        if (isset($map['operatorName'])) {
            $model->operatorName = $map['operatorName'];
        }
        if (isset($map['orgName'])) {
            $model->orgName = $map['orgName'];
        }
        if (isset($map['platform'])) {
            $model->platform = $map['platform'];
        }
        if (isset($map['platformView'])) {
            $model->platformView = $map['platformView'];
        }
        if (isset($map['realName'])) {
            $model->realName = $map['realName'];
        }
        if (isset($map['receiverName'])) {
            $model->receiverName = $map['receiverName'];
        }
        if (isset($map['receiverType'])) {
            $model->receiverType = $map['receiverType'];
        }
        if (isset($map['receiverTypeView'])) {
            $model->receiverTypeView = $map['receiverTypeView'];
        }
        if (isset($map['resource'])) {
            $model->resource = $map['resource'];
        }
        if (isset($map['resourceExtension'])) {
            $model->resourceExtension = $map['resourceExtension'];
        }
        if (isset($map['resourceSize'])) {
            $model->resourceSize = $map['resourceSize'];
        }
        if (isset($map['status'])) {
            $model->status = $map['status'];
        }
        if (isset($map['targetSpaceId'])) {
            $model->targetSpaceId = $map['targetSpaceId'];
        }
        if (isset($map['userId'])) {
            $model->userId = $map['userId'];
        }

        return $model;
    }
}
