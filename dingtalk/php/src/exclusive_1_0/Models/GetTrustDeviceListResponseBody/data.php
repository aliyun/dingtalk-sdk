<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\GetTrustDeviceListResponseBody;

use AlibabaCloud\Tea\Model;

class data extends Model
{
    /**
     * @example 1628650483
     *
     * @var int
     */
    public $createTime;

    /**
     * @example 88:92:5a:1f:e8:24
     *
     * @var string
     */
    public $macAddress;

    /**
     * @var string
     */
    public $model;

    /**
     * @example Mac
     *
     * @var string
     */
    public $platform;

    /**
     * @example 2
     *
     * @var int
     */
    public $status;

    /**
     * @var string
     */
    public $title;

    /**
     * @example 65224157501039784
     *
     * @var string
     */
    public $userId;
    protected $_name = [
        'createTime' => 'createTime',
        'macAddress' => 'macAddress',
        'model'      => 'model',
        'platform'   => 'platform',
        'status'     => 'status',
        'title'      => 'title',
        'userId'     => 'userId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->createTime) {
            $res['createTime'] = $this->createTime;
        }
        if (null !== $this->macAddress) {
            $res['macAddress'] = $this->macAddress;
        }
        if (null !== $this->model) {
            $res['model'] = $this->model;
        }
        if (null !== $this->platform) {
            $res['platform'] = $this->platform;
        }
        if (null !== $this->status) {
            $res['status'] = $this->status;
        }
        if (null !== $this->title) {
            $res['title'] = $this->title;
        }
        if (null !== $this->userId) {
            $res['userId'] = $this->userId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return data
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['createTime'])) {
            $model->createTime = $map['createTime'];
        }
        if (isset($map['macAddress'])) {
            $model->macAddress = $map['macAddress'];
        }
        if (isset($map['model'])) {
            $model->model = $map['model'];
        }
        if (isset($map['platform'])) {
            $model->platform = $map['platform'];
        }
        if (isset($map['status'])) {
            $model->status = $map['status'];
        }
        if (isset($map['title'])) {
            $model->title = $map['title'];
        }
        if (isset($map['userId'])) {
            $model->userId = $map['userId'];
        }

        return $model;
    }
}
