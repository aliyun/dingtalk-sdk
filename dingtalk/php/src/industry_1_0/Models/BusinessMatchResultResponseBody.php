<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models;

use AlibabaCloud\Tea\Model;

class BusinessMatchResultResponseBody extends Model
{
    /**
     * @var string
     */
    public $content;

    /**
     * @var bool
     */
    public $isMatched;

    /**
     * @var int
     */
    public $status;
    protected $_name = [
        'content' => 'content',
        'isMatched' => 'isMatched',
        'status' => 'status',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->content) {
            $res['content'] = $this->content;
        }
        if (null !== $this->isMatched) {
            $res['isMatched'] = $this->isMatched;
        }
        if (null !== $this->status) {
            $res['status'] = $this->status;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return BusinessMatchResultResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['content'])) {
            $model->content = $map['content'];
        }
        if (isset($map['isMatched'])) {
            $model->isMatched = $map['isMatched'];
        }
        if (isset($map['status'])) {
            $model->status = $map['status'];
        }

        return $model;
    }
}
