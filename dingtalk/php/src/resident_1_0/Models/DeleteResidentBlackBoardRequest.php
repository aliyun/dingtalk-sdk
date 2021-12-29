<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vresident_1_0\Models;

use AlibabaCloud\Tea\Model;

class DeleteResidentBlackBoardRequest extends Model
{
    /**
     * @var string
     */
    public $blackboardId;
    protected $_name = [
        'blackboardId' => 'blackboardId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->blackboardId) {
            $res['blackboardId'] = $this->blackboardId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return DeleteResidentBlackBoardRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['blackboardId'])) {
            $model->blackboardId = $map['blackboardId'];
        }

        return $model;
    }
}
