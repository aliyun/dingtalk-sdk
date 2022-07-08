<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vimpaas_1_0\Models;

use AlibabaCloud\Tea\Model;

class CreateTrustGroupRequest extends Model
{
    /**
     * @description MPASS渠道编码
     *
     * @var string
     */
    public $channel;

    /**
     * @description 素材ID
     *
     * @var string
     */
    public $iconMediaId;

    /**
     * @description 群名称
     *
     * @var string
     */
    public $name;

    /**
     * @description 其他扩展参数
     *
     * @var string[]
     */
    public $properties;

    /**
     * @description 外部系统映射唯一标识
     *
     * @var string
     */
    public $uuid;
    protected $_name = [
        'channel'     => 'channel',
        'iconMediaId' => 'iconMediaId',
        'name'        => 'name',
        'properties'  => 'properties',
        'uuid'        => 'uuid',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->channel) {
            $res['channel'] = $this->channel;
        }
        if (null !== $this->iconMediaId) {
            $res['iconMediaId'] = $this->iconMediaId;
        }
        if (null !== $this->name) {
            $res['name'] = $this->name;
        }
        if (null !== $this->properties) {
            $res['properties'] = $this->properties;
        }
        if (null !== $this->uuid) {
            $res['uuid'] = $this->uuid;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return CreateTrustGroupRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['channel'])) {
            $model->channel = $map['channel'];
        }
        if (isset($map['iconMediaId'])) {
            $model->iconMediaId = $map['iconMediaId'];
        }
        if (isset($map['name'])) {
            $model->name = $map['name'];
        }
        if (isset($map['properties'])) {
            $model->properties = $map['properties'];
        }
        if (isset($map['uuid'])) {
            $model->uuid = $map['uuid'];
        }

        return $model;
    }
}
