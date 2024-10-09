<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\QueryTemplateInfoResponseBody;

use AlibabaCloud\Tea\Model;

class grayInfo extends Model
{
    /**
     * @var int
     */
    public $tenThousandPercent;

    /**
     * @var string[]
     */
    public $whiteSet;
    protected $_name = [
        'tenThousandPercent' => 'tenThousandPercent',
        'whiteSet'           => 'whiteSet',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->tenThousandPercent) {
            $res['tenThousandPercent'] = $this->tenThousandPercent;
        }
        if (null !== $this->whiteSet) {
            $res['whiteSet'] = $this->whiteSet;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return grayInfo
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['tenThousandPercent'])) {
            $model->tenThousandPercent = $map['tenThousandPercent'];
        }
        if (isset($map['whiteSet'])) {
            if (!empty($map['whiteSet'])) {
                $model->whiteSet = $map['whiteSet'];
            }
        }

        return $model;
    }
}
