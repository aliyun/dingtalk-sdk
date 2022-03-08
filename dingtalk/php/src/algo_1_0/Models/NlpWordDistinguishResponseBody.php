<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Valgo_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Valgo_1_0\Models\NlpWordDistinguishResponseBody\wordEntities;
use AlibabaCloud\Tea\Model;

class NlpWordDistinguishResponseBody extends Model
{
    /**
     * @var string
     */
    public $requestId;

    /**
     * @var wordEntities[]
     */
    public $wordEntities;
    protected $_name = [
        'requestId'    => 'requestId',
        'wordEntities' => 'wordEntities',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->requestId) {
            $res['requestId'] = $this->requestId;
        }
        if (null !== $this->wordEntities) {
            $res['wordEntities'] = [];
            if (null !== $this->wordEntities && \is_array($this->wordEntities)) {
                $n = 0;
                foreach ($this->wordEntities as $item) {
                    $res['wordEntities'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return NlpWordDistinguishResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['requestId'])) {
            $model->requestId = $map['requestId'];
        }
        if (isset($map['wordEntities'])) {
            if (!empty($map['wordEntities'])) {
                $model->wordEntities = [];
                $n                   = 0;
                foreach ($map['wordEntities'] as $item) {
                    $model->wordEntities[$n++] = null !== $item ? wordEntities::fromMap($item) : $item;
                }
            }
        }

        return $model;
    }
}
