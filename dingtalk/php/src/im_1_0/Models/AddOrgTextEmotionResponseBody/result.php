<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\AddOrgTextEmotionResponseBody;

use AlibabaCloud\Tea\Model;

class result extends Model
{
    /**
     * @description 表情Id，用于唯一标识每个企业文字表情
     *
     * @var string
     */
    public $emotionId;
    protected $_name = [
        'emotionId' => 'emotionId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->emotionId) {
            $res['emotionId'] = $this->emotionId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return result
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['emotionId'])) {
            $model->emotionId = $map['emotionId'];
        }

        return $model;
    }
}
