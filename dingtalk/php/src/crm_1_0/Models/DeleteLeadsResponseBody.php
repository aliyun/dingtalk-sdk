<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models;

use AlibabaCloud\Tea\Model;

class DeleteLeadsResponseBody extends Model
{
    /**
     * @var string[]
     */
    public $outLeadsIds;
    protected $_name = [
        'outLeadsIds' => 'outLeadsIds',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->outLeadsIds) {
            $res['outLeadsIds'] = $this->outLeadsIds;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return DeleteLeadsResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['outLeadsIds'])) {
            if (!empty($map['outLeadsIds'])) {
                $model->outLeadsIds = $map['outLeadsIds'];
            }
        }

        return $model;
    }
}
