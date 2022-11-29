<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vsns_storage_1_0\Models\GetDentriesResponseBody;

use AlibabaCloud\SDK\Dingtalk\Vsns_storage_1_0\Models\GetDentriesResponseBody\resultItems\dentry;
use AlibabaCloud\Tea\Model;

class resultItems extends Model
{
    /**
     * @description 文件(夹)信息
     *
     * @var dentry
     */
    public $dentry;

    /**
     * @description 文件(夹)id
     *
     * @var string
     */
    public $dentryId;

    /**
     * @description 错误原因
     *
     * @var string
     */
    public $errorCode;

    /**
     * @description 文件(夹)空间id
     *
     * @var string
     */
    public $spaceId;

    /**
     * @description 是否成功
     *
     * @var bool
     */
    public $success;
    protected $_name = [
        'dentry'    => 'dentry',
        'dentryId'  => 'dentryId',
        'errorCode' => 'errorCode',
        'spaceId'   => 'spaceId',
        'success'   => 'success',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->dentry) {
            $res['dentry'] = null !== $this->dentry ? $this->dentry->toMap() : null;
        }
        if (null !== $this->dentryId) {
            $res['dentryId'] = $this->dentryId;
        }
        if (null !== $this->errorCode) {
            $res['errorCode'] = $this->errorCode;
        }
        if (null !== $this->spaceId) {
            $res['spaceId'] = $this->spaceId;
        }
        if (null !== $this->success) {
            $res['success'] = $this->success;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return resultItems
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['dentry'])) {
            $model->dentry = dentry::fromMap($map['dentry']);
        }
        if (isset($map['dentryId'])) {
            $model->dentryId = $map['dentryId'];
        }
        if (isset($map['errorCode'])) {
            $model->errorCode = $map['errorCode'];
        }
        if (isset($map['spaceId'])) {
            $model->spaceId = $map['spaceId'];
        }
        if (isset($map['success'])) {
            $model->success = $map['success'];
        }

        return $model;
    }
}
