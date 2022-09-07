<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models;

use AlibabaCloud\Tea\Model;

class GetSpaceWithDownloadAuthRequest extends Model
{
    /**
     * @description 应用的agentid。
     *
     * @var int
     */
    public $agentId;

    /**
     * @description 审批附件ID。
     *
     * @var string
     */
    public $fileId;

    /**
     * @description 附件ID列表，支持批量授权，最大列表长度：20。
     *
     * @var string[]
     */
    public $fileIdList;

    /**
     * @description 实例ID。
     *
     * 可以通过推送的审批事件中获取，参考biz_type=22。
     * @var string
     */
    public $processInstanceId;

    /**
     * @description 授权允许预览附件的用户userid。
     *
     * @var string
     */
    public $userId;
    protected $_name = [
        'agentId'           => 'agentId',
        'fileId'            => 'fileId',
        'fileIdList'        => 'fileIdList',
        'processInstanceId' => 'processInstanceId',
        'userId'            => 'userId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->agentId) {
            $res['agentId'] = $this->agentId;
        }
        if (null !== $this->fileId) {
            $res['fileId'] = $this->fileId;
        }
        if (null !== $this->fileIdList) {
            $res['fileIdList'] = $this->fileIdList;
        }
        if (null !== $this->processInstanceId) {
            $res['processInstanceId'] = $this->processInstanceId;
        }
        if (null !== $this->userId) {
            $res['userId'] = $this->userId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GetSpaceWithDownloadAuthRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['agentId'])) {
            $model->agentId = $map['agentId'];
        }
        if (isset($map['fileId'])) {
            $model->fileId = $map['fileId'];
        }
        if (isset($map['fileIdList'])) {
            if (!empty($map['fileIdList'])) {
                $model->fileIdList = $map['fileIdList'];
            }
        }
        if (isset($map['processInstanceId'])) {
            $model->processInstanceId = $map['processInstanceId'];
        }
        if (isset($map['userId'])) {
            $model->userId = $map['userId'];
        }

        return $model;
    }
}
