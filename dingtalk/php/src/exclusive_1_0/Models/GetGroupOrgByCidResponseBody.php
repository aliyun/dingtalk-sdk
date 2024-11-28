<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models;

use AlibabaCloud\Tea\Model;

class GetGroupOrgByCidResponseBody extends Model
{
    /**
     * @var int
     */
    public $groupOrganization;
    protected $_name = [
        'groupOrganization' => 'groupOrganization',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->groupOrganization) {
            $res['groupOrganization'] = $this->groupOrganization;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GetGroupOrgByCidResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['groupOrganization'])) {
            $model->groupOrganization = $map['groupOrganization'];
        }

        return $model;
    }
}
