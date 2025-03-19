<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vmail_1_0\Models\Message;

use AlibabaCloud\Tea\Model;
use GuzzleHttp\Psr7\Stream;

class body extends Model
{
    /**
     * @description This parameter is required.
     *
     * @var Stream
     */
    public $bodyHtml;

    /**
     * @description This parameter is required.
     *
     * @var Stream
     */
    public $bodyText;
    protected $_name = [
        'bodyHtml' => 'bodyHtml',
        'bodyText' => 'bodyText',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->bodyHtml) {
            $res['bodyHtml'] = $this->bodyHtml;
        }
        if (null !== $this->bodyText) {
            $res['bodyText'] = $this->bodyText;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return body
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['bodyHtml'])) {
            $model->bodyHtml = $map['bodyHtml'];
        }
        if (isset($map['bodyText'])) {
            $model->bodyText = $map['bodyText'];
        }

        return $model;
    }
}
