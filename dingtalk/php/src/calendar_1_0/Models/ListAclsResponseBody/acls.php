<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcalendar_1_0\Models\ListAclsResponseBody;

use AlibabaCloud\SDK\Dingtalk\Vcalendar_1_0\Models\ListAclsResponseBody\acls\scope;
use AlibabaCloud\Tea\Model;

class acls extends Model
{
    /**
     * @var string
     */
    public $aclId;

    /**
     * @var string
     */
    public $privilege;

    /**
     * @var scope
     */
    public $scope;
    protected $_name = [
        'aclId'     => 'aclId',
        'privilege' => 'privilege',
        'scope'     => 'scope',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->aclId) {
            $res['aclId'] = $this->aclId;
        }
        if (null !== $this->privilege) {
            $res['privilege'] = $this->privilege;
        }
        if (null !== $this->scope) {
            $res['scope'] = null !== $this->scope ? $this->scope->toMap() : null;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return acls
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['aclId'])) {
            $model->aclId = $map['aclId'];
        }
        if (isset($map['privilege'])) {
            $model->privilege = $map['privilege'];
        }
        if (isset($map['scope'])) {
            $model->scope = scope::fromMap($map['scope']);
        }

        return $model;
    }
}
