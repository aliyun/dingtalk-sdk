<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vai_search_ask_1_0\Models\RetrievalExtendParamsValue;

use AlibabaCloud\Tea\Model;

class sourceUserParams extends Model
{
    /**
     * @var string
     */
    public $nick;

    /**
     * @var string
     */
    public $staffId;
    protected $_name = [
        'nick' => 'nick',
        'staffId' => 'staffId',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->nick) {
            $res['nick'] = $this->nick;
        }
        if (null !== $this->staffId) {
            $res['staffId'] = $this->staffId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return sourceUserParams
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['nick'])) {
            $model->nick = $map['nick'];
        }
        if (isset($map['staffId'])) {
            $model->staffId = $map['staffId'];
        }

        return $model;
    }
}
