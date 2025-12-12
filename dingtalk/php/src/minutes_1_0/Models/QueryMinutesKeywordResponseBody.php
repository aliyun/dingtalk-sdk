<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vminutes_1_0\Models;

use AlibabaCloud\Tea\Model;

class QueryMinutesKeywordResponseBody extends Model
{
    /**
     * @var string[]
     */
    public $keywords;
    protected $_name = [
        'keywords' => 'keywords',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->keywords) {
            $res['keywords'] = $this->keywords;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return QueryMinutesKeywordResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['keywords'])) {
            if (!empty($map['keywords'])) {
                $model->keywords = $map['keywords'];
            }
        }

        return $model;
    }
}
