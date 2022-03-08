<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vhrm_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vhrm_1_0\Models\AddHrmPreentryRequest\groups;
use AlibabaCloud\Tea\Model;

class AddHrmPreentryRequest extends Model
{
    /**
     * @var int
     */
    public $agentId;

    /**
     * @var groups[]
     */
    public $groups;

    /**
     * @var string
     */
    public $mobile;

    /**
     * @var string
     */
    public $name;

    /**
     * @var int
     */
    public $preEntryTime;
    protected $_name = [
        'agentId'      => 'agentId',
        'groups'       => 'groups',
        'mobile'       => 'mobile',
        'name'         => 'name',
        'preEntryTime' => 'preEntryTime',
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
        if (null !== $this->groups) {
            $res['groups'] = [];
            if (null !== $this->groups && \is_array($this->groups)) {
                $n = 0;
                foreach ($this->groups as $item) {
                    $res['groups'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->mobile) {
            $res['mobile'] = $this->mobile;
        }
        if (null !== $this->name) {
            $res['name'] = $this->name;
        }
        if (null !== $this->preEntryTime) {
            $res['preEntryTime'] = $this->preEntryTime;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return AddHrmPreentryRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['agentId'])) {
            $model->agentId = $map['agentId'];
        }
        if (isset($map['groups'])) {
            if (!empty($map['groups'])) {
                $model->groups = [];
                $n             = 0;
                foreach ($map['groups'] as $item) {
                    $model->groups[$n++] = null !== $item ? groups::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['mobile'])) {
            $model->mobile = $map['mobile'];
        }
        if (isset($map['name'])) {
            $model->name = $map['name'];
        }
        if (isset($map['preEntryTime'])) {
            $model->preEntryTime = $map['preEntryTime'];
        }

        return $model;
    }
}
