<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vresident_1_0\Models;

use AlibabaCloud\Tea\Model;

class CreateResidentBlackBoardResponseBody extends Model
{
    /**
     * @var string
     */
    public $blackBoardId;
    protected $_name = [
        'blackBoardId' => 'blackBoardId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->blackBoardId) {
            $res['blackBoardId'] = $this->blackBoardId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return CreateResidentBlackBoardResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['blackBoardId'])) {
            $model->blackBoardId = $map['blackBoardId'];
        }

        return $model;
    }
}
