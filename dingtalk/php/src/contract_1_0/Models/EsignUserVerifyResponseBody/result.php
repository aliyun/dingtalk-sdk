<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcontract_1_0\Models\EsignUserVerifyResponseBody;

use AlibabaCloud\Tea\Model;

class result extends Model
{
    /**
     * @var bool
     */
    public $canAccess;
    protected $_name = [
        'canAccess' => 'canAccess',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->canAccess) {
            $res['canAccess'] = $this->canAccess;
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
        if (isset($map['canAccess'])) {
            $model->canAccess = $map['canAccess'];
        }

        return $model;
    }
}
