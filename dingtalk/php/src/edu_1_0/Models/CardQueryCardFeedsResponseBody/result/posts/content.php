<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\CardQueryCardFeedsResponseBody\result\posts;

use AlibabaCloud\Tea\Model;

class content extends Model
{
    /**
     * @example 0
     *
     * @var int
     */
    public $contentType;

    /**
     * @example {\"cardEditRedirectDTO\":{\"jumpType\":\"internal\"},\"content\":\"测试\",\"medias\":\"\\\"[{\\\\\\\"type\\\\\\\":\\\\\\\"image\\\\\\\",\\\\\\\"data\\\\\\\":{\\\\\\\"mediaUrl\\\\\\\":\\\\\\\"https://static.dingtalk.com/media/lQDPNDWzHQNv3fjNBQDNAlCwKIvuyoJrOfAFLEMmYrpsAA_592_1280.jpg\\\\\\\",\\\\\\\"thumbnailUrl\\\\\\\":\\\\\\\"https://static.dingtalk.com/media/lQDPNDWzHQNv3fjNBQDNAlCwKIvuyoJrOfAFLEMmYrpsAA_592_1280.jpg_200x200.jpg?bizType=edu_card\\\\\\\"}}]\\\"\",\"reissueCard\":false,\"resultEvaluation\":\"\",\"showName\":\"博澜爸爸\",\"sourceType\":\"\",\"studentId\":\"3000000000847390208\",\"unitOfMeasurement\":\"\"}
     *
     * @var string
     */
    public $text;
    protected $_name = [
        'contentType' => 'contentType',
        'text' => 'text',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->contentType) {
            $res['contentType'] = $this->contentType;
        }
        if (null !== $this->text) {
            $res['text'] = $this->text;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return content
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['contentType'])) {
            $model->contentType = $map['contentType'];
        }
        if (isset($map['text'])) {
            $model->text = $map['text'];
        }

        return $model;
    }
}
