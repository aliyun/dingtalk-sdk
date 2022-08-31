<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdoc_2_0\Models;

use AlibabaCloud\Tea\Model;

class GetTotalNumberOfDentriesResponseBody extends Model
{
    /**
     * @var string
     */
    public $dentriesCount;
    protected $_name = [
        'dentriesCount' => 'dentriesCount',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->dentriesCount) {
            $res['dentriesCount'] = $this->dentriesCount;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GetTotalNumberOfDentriesResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['dentriesCount'])) {
            $model->dentriesCount = $map['dentriesCount'];
        }

        return $model;
    }
}
