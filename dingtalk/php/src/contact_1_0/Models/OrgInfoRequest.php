<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models;

use AlibabaCloud\Tea\Model;

class OrgInfoRequest extends Model
{
    /**
     * @var int[]
     */
    public $orgIds;
    protected $_name = [
        'orgIds' => 'orgIds',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->orgIds) {
            $res['orgIds'] = $this->orgIds;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return OrgInfoRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['orgIds'])) {
            if (!empty($map['orgIds'])) {
                $model->orgIds = $map['orgIds'];
            }
        }

        return $model;
    }
}
