<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vconference_1_0\Models;

use AlibabaCloud\Tea\Model;

class GenerateFlashMinutesDocumentUrlResponseBody extends Model
{
    /**
     * @var string
     */
    public $minutesDocUrl;
    protected $_name = [
        'minutesDocUrl' => 'minutesDocUrl',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->minutesDocUrl) {
            $res['minutesDocUrl'] = $this->minutesDocUrl;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GenerateFlashMinutesDocumentUrlResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['minutesDocUrl'])) {
            $model->minutesDocUrl = $map['minutesDocUrl'];
        }

        return $model;
    }
}
