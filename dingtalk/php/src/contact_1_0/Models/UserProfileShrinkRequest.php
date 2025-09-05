<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models;

use AlibabaCloud\Tea\Model;

class UserProfileShrinkRequest extends Model
{
    /**
     * @var string
     */
    public $uidsShrink;
    protected $_name = [
        'uidsShrink' => 'uids',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->uidsShrink) {
            $res['uids'] = $this->uidsShrink;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return UserProfileShrinkRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['uids'])) {
            $model->uidsShrink = $map['uids'];
        }

        return $model;
    }
}
