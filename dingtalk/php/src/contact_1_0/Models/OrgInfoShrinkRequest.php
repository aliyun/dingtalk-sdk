<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models;

use AlibabaCloud\Tea\Model;

class OrgInfoShrinkRequest extends Model
{
    /**
     * @var string
     */
    public $orgIdsShrink;
    protected $_name = [
        'orgIdsShrink' => 'orgIds',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->orgIdsShrink) {
            $res['orgIds'] = $this->orgIdsShrink;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return OrgInfoShrinkRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['orgIds'])) {
            $model->orgIdsShrink = $map['orgIds'];
        }

        return $model;
    }
}
