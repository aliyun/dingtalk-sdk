<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdoc_1_0\Models;

use AlibabaCloud\Tea\Model;

class UpdateRangeRequest extends Model
{
    /**
     * @var string[][]
     */
    public $backgroundColors;

    /**
     * @var undefined[][]
     */
    public $hyperlinks;

    /**
     * @example number_format
     *
     * @var string
     */
    public $numberFormat;

    /**
     * @var string[][]
     */
    public $values;

    /**
     * @example union_id
     *
     * @var string
     */
    public $operatorId;
    protected $_name = [
        'backgroundColors' => 'backgroundColors',
        'hyperlinks'       => 'hyperlinks',
        'numberFormat'     => 'numberFormat',
        'values'           => 'values',
        'operatorId'       => 'operatorId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->backgroundColors) {
            $res['backgroundColors'] = $this->backgroundColors;
        }
        if (null !== $this->hyperlinks) {
            $res['hyperlinks'] = $this->hyperlinks;
        }
        if (null !== $this->numberFormat) {
            $res['numberFormat'] = $this->numberFormat;
        }
        if (null !== $this->values) {
            $res['values'] = $this->values;
        }
        if (null !== $this->operatorId) {
            $res['operatorId'] = $this->operatorId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return UpdateRangeRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['backgroundColors'])) {
            if (!empty($map['backgroundColors'])) {
                $model->backgroundColors = $map['backgroundColors'];
            }
        }
        if (isset($map['hyperlinks'])) {
            if (!empty($map['hyperlinks'])) {
                $model->hyperlinks = $map['hyperlinks'];
            }
        }
        if (isset($map['numberFormat'])) {
            $model->numberFormat = $map['numberFormat'];
        }
        if (isset($map['values'])) {
            if (!empty($map['values'])) {
                $model->values = $map['values'];
            }
        }
        if (isset($map['operatorId'])) {
            $model->operatorId = $map['operatorId'];
        }

        return $model;
    }
}
