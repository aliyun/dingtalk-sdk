<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vagoal_1_0\Models;

use AlibabaCloud\Tea\Model;

class AgoalUserSubAdminListRequest extends Model
{
    /**
     * @example ACCOUNT
     *
     * @var string
     */
    public $funcPermissionGroup;
    protected $_name = [
        'funcPermissionGroup' => 'funcPermissionGroup',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->funcPermissionGroup) {
            $res['funcPermissionGroup'] = $this->funcPermissionGroup;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return AgoalUserSubAdminListRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['funcPermissionGroup'])) {
            $model->funcPermissionGroup = $map['funcPermissionGroup'];
        }

        return $model;
    }
}
