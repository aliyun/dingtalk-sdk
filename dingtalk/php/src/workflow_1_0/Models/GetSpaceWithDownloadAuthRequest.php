<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models;

use AlibabaCloud\Tea\Model;

class GetSpaceWithDownloadAuthRequest extends Model
{
    /**
     * @example 8345000
     *
     * @var int
     */
    public $agentId;

    /**
     * @example 111
     *
     * @var string
     */
    public $fileId;

    /**
     * @var string[]
     */
    public $fileIdList;

    /**
     * @example a17444d1-075b-4a4d-xxxx
     *
     * @var string
     */
    public $processInstanceId;

    /**
     * @example user123
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
