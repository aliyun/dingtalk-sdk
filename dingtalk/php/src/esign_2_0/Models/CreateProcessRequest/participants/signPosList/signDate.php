<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vesign_2_0\Models\CreateProcessRequest\participants\signPosList;

use AlibabaCloud\Tea\Model;

class signDate extends Model
{
    /**
     * @var string
     */
    public $format;
    protected $_name = [
        'format' => 'format',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->format) {
            $res['format'] = $this->format;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return signDate
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['format'])) {
            $model->format = $map['format'];
        }

        return $model;
    }
}
