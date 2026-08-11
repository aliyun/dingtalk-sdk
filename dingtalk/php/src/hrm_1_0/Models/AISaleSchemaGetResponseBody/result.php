<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vhrm_1_0\Models\AISaleSchemaGetResponseBody;

use AlibabaCloud\SDK\Dingtalk\Vhrm_1_0\Models\AISaleSchemaGetResponseBody\result\fields;
use AlibabaCloud\Tea\Model;

class result extends Model
{
    /**
     * @var string
     */
    public $entityType;

    /**
     * @var fields[]
     */
    public $fields;
    protected $_name = [
        'entityType' => 'entityType',
        'fields' => 'fields',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->entityType) {
            $res['entityType'] = $this->entityType;
        }
        if (null !== $this->fields) {
            $res['fields'] = [];
            if (null !== $this->fields && \is_array($this->fields)) {
                $n = 0;
                foreach ($this->fields as $item) {
                    $res['fields'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
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
        if (isset($map['entityType'])) {
            $model->entityType = $map['entityType'];
        }
        if (isset($map['fields'])) {
            if (!empty($map['fields'])) {
                $model->fields = [];
                $n = 0;
                foreach ($map['fields'] as $item) {
                    $model->fields[$n++] = null !== $item ? fields::fromMap($item) : $item;
                }
            }
        }

        return $model;
    }
}
