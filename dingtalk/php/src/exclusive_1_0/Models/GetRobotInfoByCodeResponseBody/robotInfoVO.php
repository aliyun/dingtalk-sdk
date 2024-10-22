<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\GetRobotInfoByCodeResponseBody;

use AlibabaCloud\Tea\Model;

class robotInfoVO extends Model
{
    /**
     * @var int
     */
    public $agentId;

    /**
     * @var string
     */
    public $brief;

    /**
     * @var string
     */
    public $description;

    /**
     * @var string
     */
    public $name;

    /**
     * @var int
     */
    public $robotOrganization;
    protected $_name = [
        'agentId'           => 'agentId',
        'brief'             => 'brief',
        'description'       => 'description',
        'name'              => 'name',
        'robotOrganization' => 'robotOrganization',
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
        if (null !== $this->brief) {
            $res['brief'] = $this->brief;
        }
        if (null !== $this->description) {
            $res['description'] = $this->description;
        }
        if (null !== $this->name) {
            $res['name'] = $this->name;
        }
        if (null !== $this->robotOrganization) {
            $res['robotOrganization'] = $this->robotOrganization;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return robotInfoVO
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['agentId'])) {
            $model->agentId = $map['agentId'];
        }
        if (isset($map['brief'])) {
            $model->brief = $map['brief'];
        }
        if (isset($map['description'])) {
            $model->description = $map['description'];
        }
        if (isset($map['name'])) {
            $model->name = $map['name'];
        }
        if (isset($map['robotOrganization'])) {
            $model->robotOrganization = $map['robotOrganization'];
        }

        return $model;
    }
}
