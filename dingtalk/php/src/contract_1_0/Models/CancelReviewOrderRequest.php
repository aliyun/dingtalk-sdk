<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcontract_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vcontract_1_0\Models\CancelReviewOrderRequest\endFiles;
use AlibabaCloud\Tea\Model;

class CancelReviewOrderRequest extends Model
{
    /**
     * @var endFiles[]
     */
    public $endFiles;

    /**
     * @var string
     */
    public $extension;

    /**
     * @var string
     */
    public $orderId;
    protected $_name = [
        'endFiles'  => 'endFiles',
        'extension' => 'extension',
        'orderId'   => 'orderId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->endFiles) {
            $res['endFiles'] = [];
            if (null !== $this->endFiles && \is_array($this->endFiles)) {
                $n = 0;
                foreach ($this->endFiles as $item) {
                    $res['endFiles'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->extension) {
            $res['extension'] = $this->extension;
        }
        if (null !== $this->orderId) {
            $res['orderId'] = $this->orderId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return CancelReviewOrderRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['endFiles'])) {
            if (!empty($map['endFiles'])) {
                $model->endFiles = [];
                $n               = 0;
                foreach ($map['endFiles'] as $item) {
                    $model->endFiles[$n++] = null !== $item ? endFiles::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['extension'])) {
            $model->extension = $map['extension'];
        }
        if (isset($map['orderId'])) {
            $model->orderId = $map['orderId'];
        }

        return $model;
    }
}
