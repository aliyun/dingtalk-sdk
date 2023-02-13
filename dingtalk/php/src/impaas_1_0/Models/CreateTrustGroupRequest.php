<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vimpaas_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vimpaas_1_0\Models\CreateTrustGroupRequest\members;
use AlibabaCloud\Tea\Model;

class CreateTrustGroupRequest extends Model
{
    /**
     * @description IMPASS渠道编码
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
     * @description 群成员列表
     *
     * @var members[]
     */
    public $members;

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
     * @description 系统消息
     *
     * @var string
     */
    public $systemMsg;

    /**
     * @description 外部系统映射唯一标识
     *
     * @var string
     */
    public $uuid;
    protected $_name = [
        'channel'     => 'channel',
        'iconMediaId' => 'iconMediaId',
        'members'     => 'members',
        'name'        => 'name',
        'properties'  => 'properties',
        'systemMsg'   => 'systemMsg',
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
        if (null !== $this->members) {
            $res['members'] = [];
            if (null !== $this->members && \is_array($this->members)) {
                $n = 0;
                foreach ($this->members as $item) {
                    $res['members'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->name) {
            $res['name'] = $this->name;
        }
        if (null !== $this->properties) {
            $res['properties'] = $this->properties;
        }
        if (null !== $this->systemMsg) {
            $res['systemMsg'] = $this->systemMsg;
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
        if (isset($map['members'])) {
            if (!empty($map['members'])) {
                $model->members = [];
                $n              = 0;
                foreach ($map['members'] as $item) {
                    $model->members[$n++] = null !== $item ? members::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['name'])) {
            $model->name = $map['name'];
        }
        if (isset($map['properties'])) {
            $model->properties = $map['properties'];
        }
        if (isset($map['systemMsg'])) {
            $model->systemMsg = $map['systemMsg'];
        }
        if (isset($map['uuid'])) {
            $model->uuid = $map['uuid'];
        }

        return $model;
    }
}
