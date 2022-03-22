<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vwiki_1_0\Models\WikiWordsParseResponseBody;

use AlibabaCloud\Tea\Model;

class data extends Model
{
    /**
     * @var int
     */
    public $endIndex;

    /**
     * @var int
     */
    public $startIndex;

    /**
     * @var string
     */
    public $wordName;
    protected $_name = [
        'endIndex'   => 'endIndex',
        'startIndex' => 'startIndex',
        'wordName'   => 'wordName',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->endIndex) {
            $res['endIndex'] = $this->endIndex;
        }
        if (null !== $this->startIndex) {
            $res['startIndex'] = $this->startIndex;
        }
        if (null !== $this->wordName) {
            $res['wordName'] = $this->wordName;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return data
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['endIndex'])) {
            $model->endIndex = $map['endIndex'];
        }
        if (isset($map['startIndex'])) {
            $model->startIndex = $map['startIndex'];
        }
        if (isset($map['wordName'])) {
            $model->wordName = $map['wordName'];
        }

        return $model;
    }
}
