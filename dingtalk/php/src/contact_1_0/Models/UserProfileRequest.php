<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models;

use AlibabaCloud\Tea\Model;

class UserProfileRequest extends Model
{
    /**
     * @var int[]
     */
    public $uids;
    protected $_name = [
        'uids' => 'uids',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->uids) {
            $res['uids'] = $this->uids;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return UserProfileRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['uids'])) {
            if (!empty($map['uids'])) {
                $model->uids = $map['uids'];
            }
        }

        return $model;
    }
}
