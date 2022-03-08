<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdrive_1_0\Models;

use AlibabaCloud\Tea\Model;

class DeleteFilesRequest extends Model
{
    /**
     * @description 删除策略
     *
     * @var string
     */
    public $deletePolicy;

    /**
     * @description 文件id列表
     *
     * @var string[]
     */
    public $fileIds;

    /**
     * @description 用户id
     *
     * @var string
     */
    public $unionId;
    protected $_name = [
        'deletePolicy' => 'deletePolicy',
        'fileIds'      => 'fileIds',
        'unionId'      => 'unionId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->deletePolicy) {
            $res['deletePolicy'] = $this->deletePolicy;
        }
        if (null !== $this->fileIds) {
            $res['fileIds'] = $this->fileIds;
        }
        if (null !== $this->unionId) {
            $res['unionId'] = $this->unionId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return DeleteFilesRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['deletePolicy'])) {
            $model->deletePolicy = $map['deletePolicy'];
        }
        if (isset($map['fileIds'])) {
            if (!empty($map['fileIds'])) {
                $model->fileIds = $map['fileIds'];
            }
        }
        if (isset($map['unionId'])) {
            $model->unionId = $map['unionId'];
        }

        return $model;
    }
}
