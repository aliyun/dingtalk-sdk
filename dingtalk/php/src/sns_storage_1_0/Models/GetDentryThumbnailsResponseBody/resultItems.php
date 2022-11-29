<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vsns_storage_1_0\Models\GetDentryThumbnailsResponseBody;

use AlibabaCloud\SDK\Dingtalk\Vsns_storage_1_0\Models\GetDentryThumbnailsResponseBody\resultItems\thumbnail;
use AlibabaCloud\Tea\Model;

class resultItems extends Model
{
    /**
     * @description 源文件(夹)id
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
     * @description 源文件(夹)空间id
     *
     * @var string
     */
    public $spaceId;

    /**
     * @description 是否成功获取到缩略图
     *
     * @var bool
     */
    public $success;

    /**
     * @description 缩略图信息
     *
     * @var thumbnail
     */
    public $thumbnail;
    protected $_name = [
        'dentryId'  => 'dentryId',
        'errorCode' => 'errorCode',
        'spaceId'   => 'spaceId',
        'success'   => 'success',
        'thumbnail' => 'thumbnail',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
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
        if (null !== $this->thumbnail) {
            $res['thumbnail'] = null !== $this->thumbnail ? $this->thumbnail->toMap() : null;
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
        if (isset($map['thumbnail'])) {
            $model->thumbnail = thumbnail::fromMap($map['thumbnail']);
        }

        return $model;
    }
}
