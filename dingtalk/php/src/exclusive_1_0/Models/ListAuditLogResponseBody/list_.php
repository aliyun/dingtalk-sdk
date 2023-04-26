<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\ListAuditLogResponseBody;

use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\ListAuditLogResponseBody\list_\docMemberList;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\ListAuditLogResponseBody\list_\docReceiverList;
use AlibabaCloud\Tea\Model;

class list_ extends Model
{
    /**
     * @example 0
     *
     * @var int
     */
    public $action;

    /**
     * @example 企业群
     *
     * @var string
     */
    public $actionView;

    /**
     * @example 11258620701
     *
     * @var string
     */
    public $bizId;

    /**
     * @var docMemberList[]
     */
    public $docMemberList;

    /**
     * @var string
     */
    public $docMobileUrl;

    /**
     * @var string
     */
    public $docPcUrl;

    /**
     * @var docReceiverList[]
     */
    public $docReceiverList;

    /**
     * @example 1577601221260
     *
     * @var int
     */
    public $gmtCreate;

    /**
     * @example 1577601221260
     *
     * @var int
     */
    public $gmtModified;

    /**
     * @example 1.1.1.1
     *
     * @var string
     */
    public $ipAddress;

    /**
     * @example 2
     *
     * @var int
     */
    public $operateModule;

    /**
     * @example 企业群
     *
     * @var string
     */
    public $operateModuleView;

    /**
     * @example 测试
     *
     * @var string
     */
    public $operatorName;

    /**
     * @example 水果公司
     *
     * @var string
     */
    public $orgName;

    /**
     * @example 11
     *
     * @var int
     */
    public $platform;

    /**
     * @example WIN
     *
     * @var string
     */
    public $platformView;

    /**
     * @example 张三
     *
     * @var string
     */
    public $realName;

    /**
     * @example 总经理办公室
     *
     * @var string
     */
    public $receiverName;

    /**
     * @example 0
     *
     * @var int
     */
    public $receiverType;

    /**
     * @example 单聊
     *
     * @var string
     */
    public $receiverTypeView;

    /**
     * @example 文件名
     *
     * @var string
     */
    public $resource;

    /**
     * @example doc
     *
     * @var string
     */
    public $resourceExtension;

    /**
     * @example 1024
     *
     * @var int
     */
    public $resourceSize;

    /**
     * @example 0
     *
     * @var int
     */
    public $status;

    /**
     * @example 11258620
     *
     * @var int
     */
    public $targetSpaceId;

    /**
     * @example 123
     *
     * @var string
     */
    public $userId;

    /**
     * @var int
     */
    public $workSpaceId;

    /**
     * @var string
     */
    public $workSpaceMobileUrl;

    /**
     * @var string
     */
    public $workSpaceName;

    /**
     * @var string
     */
    public $workSpacePcUrl;
    protected $_name = [
        'action'             => 'action',
        'actionView'         => 'actionView',
        'bizId'              => 'bizId',
        'docMemberList'      => 'docMemberList',
        'docMobileUrl'       => 'docMobileUrl',
        'docPcUrl'           => 'docPcUrl',
        'docReceiverList'    => 'docReceiverList',
        'gmtCreate'          => 'gmtCreate',
        'gmtModified'        => 'gmtModified',
        'ipAddress'          => 'ipAddress',
        'operateModule'      => 'operateModule',
        'operateModuleView'  => 'operateModuleView',
        'operatorName'       => 'operatorName',
        'orgName'            => 'orgName',
        'platform'           => 'platform',
        'platformView'       => 'platformView',
        'realName'           => 'realName',
        'receiverName'       => 'receiverName',
        'receiverType'       => 'receiverType',
        'receiverTypeView'   => 'receiverTypeView',
        'resource'           => 'resource',
        'resourceExtension'  => 'resourceExtension',
        'resourceSize'       => 'resourceSize',
        'status'             => 'status',
        'targetSpaceId'      => 'targetSpaceId',
        'userId'             => 'userId',
        'workSpaceId'        => 'workSpaceId',
        'workSpaceMobileUrl' => 'workSpaceMobileUrl',
        'workSpaceName'      => 'workSpaceName',
        'workSpacePcUrl'     => 'workSpacePcUrl',
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
        if (null !== $this->docMobileUrl) {
            $res['docMobileUrl'] = $this->docMobileUrl;
        }
        if (null !== $this->docPcUrl) {
            $res['docPcUrl'] = $this->docPcUrl;
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
        if (null !== $this->workSpaceId) {
            $res['workSpaceId'] = $this->workSpaceId;
        }
        if (null !== $this->workSpaceMobileUrl) {
            $res['workSpaceMobileUrl'] = $this->workSpaceMobileUrl;
        }
        if (null !== $this->workSpaceName) {
            $res['workSpaceName'] = $this->workSpaceName;
        }
        if (null !== $this->workSpacePcUrl) {
            $res['workSpacePcUrl'] = $this->workSpacePcUrl;
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
        if (isset($map['docMobileUrl'])) {
            $model->docMobileUrl = $map['docMobileUrl'];
        }
        if (isset($map['docPcUrl'])) {
            $model->docPcUrl = $map['docPcUrl'];
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
        if (isset($map['workSpaceId'])) {
            $model->workSpaceId = $map['workSpaceId'];
        }
        if (isset($map['workSpaceMobileUrl'])) {
            $model->workSpaceMobileUrl = $map['workSpaceMobileUrl'];
        }
        if (isset($map['workSpaceName'])) {
            $model->workSpaceName = $map['workSpaceName'];
        }
        if (isset($map['workSpacePcUrl'])) {
            $model->workSpacePcUrl = $map['workSpacePcUrl'];
        }

        return $model;
    }
}
