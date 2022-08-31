<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdoc_2_0\Models;

use AlibabaCloud\Tea\Model;

class GetTotalNumberOfSpacesResponseBody extends Model
{
    /**
     * @var string
     */
    public $spacesCount;
    protected $_name = [
        'spacesCount' => 'spacesCount',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->spacesCount) {
            $res['spacesCount'] = $this->spacesCount;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GetTotalNumberOfSpacesResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['spacesCount'])) {
            $model->spacesCount = $map['spacesCount'];
        }

        return $model;
    }
}
