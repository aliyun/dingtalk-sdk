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
    public $preEntryTime;

    /**
     * @var string
     */
    public $name;

    /**
     * @var string
     */
    public $mobile;

    /**
     * @var int
     */
    public $agentId;

    /**
     * @var groups[]
     */
    public $groups;
    protected $_name = [
        'preEntryTime' => 'preEntryTime',
        'name'         => 'name',
        'mobile'       => 'mobile',
        'agentId'      => 'agentId',
        'groups'       => 'groups',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->preEntryTime) {
            $res['preEntryTime'] = $this->preEntryTime;
        }
        if (null !== $this->name) {
            $res['name'] = $this->name;
        }
        if (null !== $this->mobile) {
            $res['mobile'] = $this->mobile;
        }
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
        if (isset($map['preEntryTime'])) {
            $model->preEntryTime = $map['preEntryTime'];
        }
        if (isset($map['name'])) {
            $model->name = $map['name'];
        }
        if (isset($map['mobile'])) {
            $model->mobile = $map['mobile'];
        }
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

        return $model;
    }
}
