<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vstorage_1_0\Models\GetCurrentAppResponseBody;

use AlibabaCloud\SDK\Dingtalk\Vstorage_1_0\Models\GetCurrentAppResponseBody\app\partitions;
use AlibabaCloud\Tea\Model;

class app extends Model
{
    /**
     * @description 开放平台应用appId
     *
     * @var string
     */
    public $appId;

    /**
     * @description 应用归属企业的id
     *
     * @var string
     */
    public $corpId;

    /**
     * @description 应用创建时间
     *
     * @var string
     */
    public $createTime;

    /**
     * @description 应用修改时间
     *
     * @var string
     */
    public $modifiedTime;

    /**
     * @description 应用名称，对应开放平台应用名称
     *
     * @var string
     */
    public $name;

    /**
     * @description 分区容量信息
     * 3
     * @var partitions[]
     */
    public $partitions;
    protected $_name = [
        'appId'        => 'appId',
        'corpId'       => 'corpId',
        'createTime'   => 'createTime',
        'modifiedTime' => 'modifiedTime',
        'name'         => 'name',
        'partitions'   => 'partitions',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->appId) {
            $res['appId'] = $this->appId;
        }
        if (null !== $this->corpId) {
            $res['corpId'] = $this->corpId;
        }
        if (null !== $this->createTime) {
            $res['createTime'] = $this->createTime;
        }
        if (null !== $this->modifiedTime) {
            $res['modifiedTime'] = $this->modifiedTime;
        }
        if (null !== $this->name) {
            $res['name'] = $this->name;
        }
        if (null !== $this->partitions) {
            $res['partitions'] = [];
            if (null !== $this->partitions && \is_array($this->partitions)) {
                $n = 0;
                foreach ($this->partitions as $item) {
                    $res['partitions'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return app
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['appId'])) {
            $model->appId = $map['appId'];
        }
        if (isset($map['corpId'])) {
            $model->corpId = $map['corpId'];
        }
        if (isset($map['createTime'])) {
            $model->createTime = $map['createTime'];
        }
        if (isset($map['modifiedTime'])) {
            $model->modifiedTime = $map['modifiedTime'];
        }
        if (isset($map['name'])) {
            $model->name = $map['name'];
        }
        if (isset($map['partitions'])) {
            if (!empty($map['partitions'])) {
                $model->partitions = [];
                $n                 = 0;
                foreach ($map['partitions'] as $item) {
                    $model->partitions[$n++] = null !== $item ? partitions::fromMap($item) : $item;
                }
            }
        }

        return $model;
    }
}
