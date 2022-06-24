<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\GetTrustDeviceListResponseBody;

use AlibabaCloud\Tea\Model;

class data extends Model
{
    /**
     * @description 创建时间
     *
     * @var int
     */
    public $createTime;

    /**
     * @description mac地址
     *
     * @var string
     */
    public $macAddress;

    /**
     * @description 版本信息：Android端: Android,10，IOS端：iOS,12.0.1
     *
     * @var string
     */
    public $model;

    /**
     * @description 平台类型
     *
     * @var string
     */
    public $platform;

    /**
     * @description 设备状态
     *
     * @var int
     */
    public $status;

    /**
     * @description 设备名称
     *
     * @var string
     */
    public $title;

    /**
     * @description 员工Id
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
