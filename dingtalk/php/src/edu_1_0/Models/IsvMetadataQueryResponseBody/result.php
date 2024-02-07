<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\IsvMetadataQueryResponseBody;

use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\IsvMetadataQueryResponseBody\result\fields;
use AlibabaCloud\Tea\Model;

class result extends Model
{
    /**
     * @var fields[]
     */
    public $fields;

    /**
     * @example tb_test01
     *
     * @var string
     */
    public $tableCode;

    /**
     * @var bool
     */
    public $tableExist;
    protected $_name = [
        'fields'     => 'fields',
        'tableCode'  => 'tableCode',
        'tableExist' => 'tableExist',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->fields) {
            $res['fields'] = [];
            if (null !== $this->fields && \is_array($this->fields)) {
                $n = 0;
                foreach ($this->fields as $item) {
                    $res['fields'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->tableCode) {
            $res['tableCode'] = $this->tableCode;
        }
        if (null !== $this->tableExist) {
            $res['tableExist'] = $this->tableExist;
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
        if (isset($map['fields'])) {
            if (!empty($map['fields'])) {
                $model->fields = [];
                $n             = 0;
                foreach ($map['fields'] as $item) {
                    $model->fields[$n++] = null !== $item ? fields::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['tableCode'])) {
            $model->tableCode = $map['tableCode'];
        }
        if (isset($map['tableExist'])) {
            $model->tableExist = $map['tableExist'];
        }

        return $model;
    }
}
