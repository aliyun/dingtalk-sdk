<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models;

use AlibabaCloud\Tea\Model;

class QueryClueFollowStatusRequest extends Model
{
    /**
     * @var string
     */
    public $clueId;
    protected $_name = [
        'clueId' => 'clueId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->clueId) {
            $res['clueId'] = $this->clueId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return QueryClueFollowStatusRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['clueId'])) {
            $model->clueId = $map['clueId'];
        }

        return $model;
    }
}
