<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdrive_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vdrive_1_0\Models\ManagementModifySpaceResponseBody\spaces;
use AlibabaCloud\Tea\Model;

class ManagementModifySpaceResponseBody extends Model
{
    /**
     * @description 空间列表
     *
     * @var spaces[]
     */
    public $spaces;
    protected $_name = [
        'spaces' => 'spaces',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->spaces) {
            $res['spaces'] = [];
            if (null !== $this->spaces && \is_array($this->spaces)) {
                $n = 0;
                foreach ($this->spaces as $item) {
                    $res['spaces'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return ManagementModifySpaceResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['spaces'])) {
            if (!empty($map['spaces'])) {
                $model->spaces = [];
                $n             = 0;
                foreach ($map['spaces'] as $item) {
                    $model->spaces[$n++] = null !== $item ? spaces::fromMap($item) : $item;
                }
            }
        }

        return $model;
    }
}
