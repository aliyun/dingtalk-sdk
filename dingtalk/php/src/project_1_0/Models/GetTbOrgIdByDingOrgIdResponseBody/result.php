<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vproject_1_0\Models\GetTbOrgIdByDingOrgIdResponseBody;

use AlibabaCloud\Tea\Model;

class result extends Model
{
    /**
     * @description This parameter is required.
     *
     * @example 50c32afae8cf1439xxxx
     *
     * @var string
     */
    public $tbOrganizationId;
    protected $_name = [
        'tbOrganizationId' => 'tbOrganizationId',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->tbOrganizationId) {
            $res['tbOrganizationId'] = $this->tbOrganizationId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return result
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['tbOrganizationId'])) {
            $model->tbOrganizationId = $map['tbOrganizationId'];
        }

        return $model;
    }
}
