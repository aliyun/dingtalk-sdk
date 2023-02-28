<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdoc_2_0\Models;

use AlibabaCloud\Tea\Model;

class GetStarInfoResponseBody extends Model
{
    /**
     * @description 是否已星标
     *
     * @var bool
     */
    public $starred;
    protected $_name = [
        'starred' => 'starred',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->starred) {
            $res['starred'] = $this->starred;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GetStarInfoResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['starred'])) {
            $model->starred = $map['starred'];
        }

        return $model;
    }
}
