<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vorg_culture_1_0\Models\QueryUserHonorsResponseBody;

use AlibabaCloud\SDK\Dingtalk\Vorg_culture_1_0\Models\QueryUserHonorsResponseBody\result\honors;
use AlibabaCloud\Tea\Model;

class result extends Model
{
    /**
     * @var honors[]
     */
    public $honors;

    /**
     * @var string
     */
    public $nextToken;
    protected $_name = [
        'honors'    => 'honors',
        'nextToken' => 'nextToken',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->honors) {
            $res['honors'] = [];
            if (null !== $this->honors && \is_array($this->honors)) {
                $n = 0;
                foreach ($this->honors as $item) {
                    $res['honors'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->nextToken) {
            $res['nextToken'] = $this->nextToken;
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
        if (isset($map['honors'])) {
            if (!empty($map['honors'])) {
                $model->honors = [];
                $n             = 0;
                foreach ($map['honors'] as $item) {
                    $model->honors[$n++] = null !== $item ? honors::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['nextToken'])) {
            $model->nextToken = $map['nextToken'];
        }

        return $model;
    }
}
