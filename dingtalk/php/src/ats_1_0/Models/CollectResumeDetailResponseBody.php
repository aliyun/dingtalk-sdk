<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vats_1_0\Models;

use AlibabaCloud\Tea\Model;

class CollectResumeDetailResponseBody extends Model
{
    /**
     * @var string
     */
    public $resumeId;
    protected $_name = [
        'resumeId' => 'resumeId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->resumeId) {
            $res['resumeId'] = $this->resumeId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return CollectResumeDetailResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['resumeId'])) {
            $model->resumeId = $map['resumeId'];
        }

        return $model;
    }
}
