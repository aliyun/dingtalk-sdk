<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdrive_1_0\Models;

use AlibabaCloud\Tea\Model;

class GrantPrivilegeOfCustomSpaceRequest extends Model
{
    /**
     * @description 权限类型
     *
     * @var string
     */
    public $type;

    /**
     * @description 被授予权限的员工id
     *
     * @var string
     */
    public $userId;

    /**
     * @description 授权访问的文件id列表
     *
     * @var string[]
     */
    public $fileIds;

    /**
     * @description 权限有效时间
     *
     * @var int
     */
    public $duration;

    /**
     * @description 用户id
     *
     * @var string
     */
    public $unionId;
    protected $_name = [
        'type'     => 'type',
        'userId'   => 'userId',
        'fileIds'  => 'fileIds',
        'duration' => 'duration',
        'unionId'  => 'unionId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->type) {
            $res['type'] = $this->type;
        }
        if (null !== $this->userId) {
            $res['userId'] = $this->userId;
        }
        if (null !== $this->fileIds) {
            $res['fileIds'] = $this->fileIds;
        }
        if (null !== $this->duration) {
            $res['duration'] = $this->duration;
        }
        if (null !== $this->unionId) {
            $res['unionId'] = $this->unionId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GrantPrivilegeOfCustomSpaceRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['type'])) {
            $model->type = $map['type'];
        }
        if (isset($map['userId'])) {
            $model->userId = $map['userId'];
        }
        if (isset($map['fileIds'])) {
            if (!empty($map['fileIds'])) {
                $model->fileIds = $map['fileIds'];
            }
        }
        if (isset($map['duration'])) {
            $model->duration = $map['duration'];
        }
        if (isset($map['unionId'])) {
            $model->unionId = $map['unionId'];
        }

        return $model;
    }
}
