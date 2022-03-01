<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Valgo_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Valgo_1_0\Models\NlpWordDistinguishResponseBody\wordEntities;
use AlibabaCloud\Tea\Model;

class NlpWordDistinguishResponseBody extends Model
{
    /**
     * @var wordEntities[]
     */
    public $wordEntities;

    /**
     * @var string
     */
    public $requestId;
    protected $_name = [
        'wordEntities' => 'wordEntities',
        'requestId'    => 'requestId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->wordEntities) {
            $res['wordEntities'] = [];
            if (null !== $this->wordEntities && \is_array($this->wordEntities)) {
                $n = 0;
                foreach ($this->wordEntities as $item) {
                    $res['wordEntities'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->requestId) {
            $res['requestId'] = $this->requestId;
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
        if (isset($map['wordEntities'])) {
            if (!empty($map['wordEntities'])) {
                $model->wordEntities = [];
                $n                   = 0;
                foreach ($map['wordEntities'] as $item) {
                    $model->wordEntities[$n++] = null !== $item ? wordEntities::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['requestId'])) {
            $model->requestId = $map['requestId'];
        }

        return $model;
    }
}
